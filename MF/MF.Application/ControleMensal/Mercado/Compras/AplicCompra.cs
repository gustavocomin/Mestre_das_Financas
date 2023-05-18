using HtmlAgilityPack;
using MF.Application.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.Functions;
using MF.Domain.ControleMensal.Mercado.Compras;
using MF.Domain.ControleMensal.Mercado.Compras.Models;
using System.Transactions;

namespace MF.Application.ControleMensal.Mercado.Compras
{
    public class AplicCompra : IAplicCompra
    {
        private readonly IRepCompra _repCompra;
        private readonly IRepEmpresa _repEmpresa;
        private readonly IAplicItemCompra _aplicItemCompra;

        public AplicCompra(IRepCompra repCompra, IAplicItemCompra aplicItemCompra, IRepEmpresa repEmpresa)
        {
            _repCompra = repCompra;
            _aplicItemCompra = aplicItemCompra;
            _repEmpresa = repEmpresa;
        }

        public CompraView Insert(CompraDto dto)
        {
            try
            {
                Compra compra = new(dto);
                _repCompra.SaveChanges(compra);
                CompraView view = new(compra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir compra. Erro: {e.Message}");
            }
        }

        public CompraView Update(int id, CompraDto dto)
        {
            try
            {
                Compra compra = _repCompra.FindById<Compra>(id) ?? throw new Exception($"Não foi possivél encontrar a compra de ID = {id}.");
                compra = new Compra().AtualizaCompra(compra, dto);
                _repCompra.SaveChanges(compra);
                CompraView view = new(compra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar compra. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repCompra.DeleteById<Compra>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar compra. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repCompra.DeleteByIds<Compra>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar compras. Erro: {e.Message}");
            }
        }

        public CompraView FindById(int id)
        {
            try
            {
                Compra compra = _repCompra.FindById<Compra>(id) ?? throw new Exception($"Não foi possivél encontrar a compra de ID = {id}.");
                CompraView view = new(compra);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar compra. Erro: {e.Message}");
            }
        }

        public List<CompraView> FindAll()
        {
            try
            {
                List<Compra> compras = _repCompra.FindAll<Compra>();
                List<CompraView> view = new CompraView().ListCompraView(compras);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar compras. Erro: {e.Message}");
            }
        }

        public async Task<CompraView> ImportarNFCEAsync(string url)
        {
            try
            {
                url = "https://sat.sef.sc.gov.br/nfce/consulta?p=42230583261420001040652160000136911904149519|2|1|1|8E569520F1CC6F809F50E89362EBBC5DECE6A65E";
                string content = await GetNFCEAsync(url);
                CompraView view = MapearDadosNFCE(content, url);

                return view;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static async Task<string> GetNFCEAsync(string url)
        {
            try
            {
                using HttpClient client = new();
                HttpResponseMessage response = await client.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();

                return content;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao acessar NFCE. Erro: {e.Message}. {e.InnerException}");
            }
        }

        private CompraView MapearDadosNFCE(string content, string url)
        {
            using var scope = new TransactionScope();
            try
            {
                Compra compra = new();
                HtmlDocument doc = new();
                doc.LoadHtml(content);
                HtmlNodeCollection tableNodes = doc.DocumentNode.SelectNodes("//table[contains(@class, 'box')]");

                HtmlNodeCollection tdNodes = tableNodes[0].SelectNodes(".//td");
                MapearDadosCabecalhoNFCE(tdNodes, compra);

                tdNodes = tableNodes[1].SelectNodes(".//td");
                MapearDadosEmitenteNFCE(tdNodes, compra);
                MapearDados(compra, url);
                _repCompra.SaveChanges(compra);

                tdNodes = tableNodes[2].SelectNodes(".//td");
                compra.Itens = _aplicItemCompra.ImportarItensNFCE(tdNodes, compra.Id);

                compra.AtualizaCalculos();

                _repCompra.SaveChanges(compra);

                CompraView view = new(compra);
                scope.Complete();

                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro durante a transação: {e.Message}. {e.InnerException}");
            }
        }

        private static void MapearDadosCabecalhoNFCE(HtmlNodeCollection tdNodes, Compra compra)
        {
            try
            {
                if (tdNodes != null)
                {
                    foreach (HtmlNode tdNode in tdNodes)
                    {
                        HtmlNode spanNode = tdNode.SelectSingleNode("./span");

                        if (spanNode != null)
                        {
                            string spanText = spanNode.InnerText.Trim();

                            switch (tdNodes[tdNode])
                            {
                                case 2:
                                    compra.NumeroNF = int.Parse(spanText);
                                    break;
                                case 3:
                                    compra.DataCompra = DateTime.Parse(spanText).ToUniversalTime();
                                    break;
                                case 5:
                                    compra.ValorTotalNF = decimal.Parse(spanText);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao mapear dados do cabeçalho da NFCE. Erro: {e.Message} {e.InnerException}");
            }
        }

        private void MapearDadosEmitenteNFCE(HtmlNodeCollection tdNodes, Compra compra)
        {
            if (tdNodes != null)
            {
                string cnpjEmpresa = "";
                string nomeEmpresa = "";

                foreach (HtmlNode tdNode in tdNodes)
                {
                    try
                    {
                        HtmlNode spanNode = tdNode.SelectSingleNode("./span");

                        if (spanNode != null)
                        {
                            string spanText = spanNode.InnerText.Trim();

                            switch (tdNodes[tdNode])
                            {
                                case 0:
                                    cnpjEmpresa = spanText;
                                    break;
                                case 1:
                                    nomeEmpresa = spanText;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Erro ao mapear dados do emitente da NFCE. Erro: {e.Message} {e.InnerException}");
                    }
                }
                MapearEmpresa(compra, cnpjEmpresa, nomeEmpresa);
            }
        }

        private void MapearEmpresa(Compra compra, string cnpjEmpresa, string nomeEmpresa)
        {
            cnpjEmpresa = CommonFunctions.RemoveCaracterEspecial(cnpjEmpresa);
            List<Empresa> empresas = _repEmpresa.BuscarEmpresaPorNomeOuCNPJ(cnpjEmpresa, nomeEmpresa);
            if (!empresas.Any())
            {
                Empresa empresa = new(cnpjEmpresa, nomeEmpresa);
                _repEmpresa.SaveChanges(empresa);
                compra.Empresa = empresa;
                compra.CodigoEmpresa = empresa.Id;
                return;
            }

            if (empresas.Count >= 1)
            {
                Empresa empresa = empresas.FirstOrDefault(x => x.CnpjEmpresa == cnpjEmpresa);
                compra.Empresa = empresa;
                compra.CodigoEmpresa = empresa.Id;
            }
        }

        private static void MapearDados(Compra compra, string linkNF)
        {
            compra.Descricao = $"Compra de mercado no mês {compra.DataCompra.Month}.";
            compra.LinkNF = linkNF;
        }
    }
}