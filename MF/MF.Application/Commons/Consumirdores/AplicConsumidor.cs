using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Consumirdores.Models;

namespace MF.Application.Commons.Consumirdores
{
    public class AplicConsumidor : IAplicConsumidor
    {
        private readonly IRepConsumidor _repConsumidor;

        public AplicConsumidor(IRepConsumidor repConsumidor)
        {
            _repConsumidor = repConsumidor;
        }

        public ConsumidorView Insert(ConsumidorDto dto)
        {
            try
            {
                Consumidor consumidor = new(dto);
                _repConsumidor.SaveChanges(consumidor);
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir consumidor. Erro: {e.Message} - {e.InnerException}");
            }
        }

        public ConsumidorView Update(int id, ConsumidorDto dto)
        {
            try
            {
                Consumidor consumidor = _repConsumidor.FindById<Consumidor>(id) ?? throw new Exception($"Não foi possivél encontrar o consumidor de ID = {id}.");
                consumidor = new Consumidor().AtualizaConsumidor(consumidor, dto);
                _repConsumidor.SaveChanges(consumidor);
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar consumidor. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repConsumidor.DeleteById<Consumidor>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar consumidor. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repConsumidor.DeleteByIds<Consumidor>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar consumidores. Erro: {e.Message}");
            }
        }

        public ConsumidorView FindById(int id)
        {
            try
            {
                Consumidor consumidor = _repConsumidor.FindById<Consumidor>(id) ?? throw new Exception($"Não foi possivél encontrar o consumidor de ID = {id}.");
                ConsumidorView view = new(consumidor);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidor. Erro: {e.Message}");
            }
        }

        public List<ConsumidorView> FindAll()
        {
            //try
            //{
            //    string url = "https://sat.sef.sc.gov.br/nfce/consulta?p=42230583261420001040652160000136911904149519|2|1|1|8E569520F1CC6F809F50E89362EBBC5DECE6A65E";
            //    List<List<string>> tableData = new();

            //    // Fazer a solicitação HTTP
            //    using (HttpClient client = new())
            //    {
            //        HttpResponseMessage response = await client.GetAsync(url);
            //        string content = await response.Content.ReadAsStringAsync();

            //        // Load the HTML content into an HtmlDocument
            //        HtmlDocument doc = new();
            //        doc.LoadHtml(content);

            //        // Select the table with class "box"
            //        HtmlNode tableNode = doc.DocumentNode.SelectSingleNode("//table[contains(@class, 'box')]");
            //        HtmlNodeCollection tableNodes = doc.DocumentNode.SelectNodes("//table[contains(@class, 'box')]");

            //        MapeiaDadosNFCE(tableNodes);
            //    }
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}

            try
            {
                List<ConsumidorView> view = new();
                List<Consumidor> consumidores = _repConsumidor.FindAll<Consumidor>();
                if (consumidores != null && consumidores.Count > 0)
                    view = new ConsumidorView().ListConsumidorView(consumidores);

                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidores. Erro: {e.Message}");
            }
        }

        public ConsumidorView FindByEmail(string email)
        {
            try
            {
                //ConsumidorView consumidor = FindAllAsync().Where(x => x.Email.Trim().ToUpper() == email.Trim().ToUpper()).FirstOrDefault();

                return new ConsumidorView();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar consumidor por Email. Email = {email}. Erro: {e.Message} - {e.InnerException}");
            }
        }

        //private void MapeiaDadosNFCE(HtmlNodeCollection tableNodes)
        //{
        //    Teste teste = new();
        //    HtmlDocument doc = new();

        //    doc.LoadHtml(tableNodes[0].ToString());
        //    HtmlNodeCollection tdNodes = tableNodes[0].SelectNodes(".//td");
        //    MapeiaDadosCabecalhoNFCE(tdNodes, teste);

        //    tdNodes = tableNodes[1].SelectNodes(".//td");
        //    MapeiaDadosEmitenteNFCE(tdNodes, teste);

        //    tdNodes = tableNodes[2].SelectNodes(".//td");
        //    MapeiaDadosItensNFCE(tdNodes, teste);
        //}

        //private void MapeiaDadosCabecalhoNFCE(HtmlNodeCollection tdNodes, Teste teste)
        //{

        //    if (tdNodes != null)
        //    {
        //        foreach (HtmlNode tdNode in tdNodes)
        //        {
        //            // Selecionar o nó 'span' dentro do nó 'td'
        //            HtmlNode spanNode = tdNode.SelectSingleNode("./span");

        //            if (spanNode != null)
        //            {
        //                string spanText = spanNode.InnerText.Trim();

        //                switch (tdNodes[tdNode])
        //                {
        //                    case 0:
        //                        teste.Modelo = spanText;
        //                        break;
        //                    case 1:
        //                        teste.Serie = spanText;
        //                        break;
        //                    case 2:
        //                        teste.Numero = spanText;
        //                        break;
        //                    case 3:
        //                        teste.DataEmissao = DateTime.Parse(spanText);
        //                        break;
        //                    case 5:
        //                        teste.ValorTotal = spanText;
        //                        break;
        //                    default:
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void MapeiaDadosEmitenteNFCE(HtmlNodeCollection tdNodes, Teste teste)
        //{
        //    if (tdNodes != null)
        //    {
        //        foreach (HtmlNode tdNode in tdNodes)
        //        {
        //            // Selecionar o nó 'span' dentro do nó 'td'
        //            HtmlNode spanNode = tdNode.SelectSingleNode("./span");

        //            if (spanNode != null)
        //            {
        //                string spanText = spanNode.InnerText.Trim();

        //                switch (tdNodes[tdNode])
        //                {
        //                    case 0:
        //                        teste.CNPJ = spanText;
        //                        break;
        //                    case 1:
        //                        teste.Nome = spanText;
        //                        break;
        //                    default:
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}
        //private void MapeiaDadosItensNFCE(HtmlNodeCollection tdNodes, Teste teste)
        //{
        //    List<ItensTeste> itens = new();
        //    if (tdNodes != null)
        //    {
        //        ItensTeste item = null;
        //        for (int i = 0; i < tdNodes.Count; i++)
        //        {
        //            HtmlNode tdNode = tdNodes[i];
        //            HtmlNode spanNode = tdNode.SelectSingleNode("./span");

        //            if (i % 6 == 0)
        //            {
        //                item = new ItensTeste();
        //                itens.Add(item);
        //            }

        //            if (spanNode != null)
        //            {
        //                string spanText = spanNode.InnerText.Trim();

        //                switch (i % 6)
        //                {
        //                    case 0:
        //                        item.Seq = int.Parse(spanText);
        //                        break;
        //                    case 1:
        //                        item.Descricao = spanText;
        //                        break;
        //                    case 2:
        //                        item.Quantidade = decimal.Parse(spanText);
        //                        break;
        //                    case 4:
        //                        item.UnCompra = spanText;
        //                        break;
        //                    case 5:
        //                        item.ValorUnit = decimal.Parse(spanText);
        //                        break;
        //                    case 6:
        //                        item.ValorTotal = decimal.Parse(spanText);
        //                        break;

        //                }
        //            }
        //        }
        //    }
        //}
    }
}