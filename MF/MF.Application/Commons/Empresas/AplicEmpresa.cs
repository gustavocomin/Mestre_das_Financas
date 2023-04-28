using MF.Domain.Commons.Empresas;
using MF.Domain.Commons.Empresas.Models;

namespace MF.Application.Commons.Empresas
{
    public class AplicEmpresa : IAplicEmpresa
    {
        private readonly IRepEmpresa _repEmpresa;

        public AplicEmpresa(IRepEmpresa repEmpresa)
        {
            _repEmpresa = repEmpresa;
        }

        public EmpresaView Insert(EmpresaDto dto)
        {
            try
            {
                Empresa empresa = new(dto);
                _repEmpresa.SaveChanges(empresa);
                EmpresaView view = new(empresa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir empresa. Erro: {e.Message}");
            }
        }

        public EmpresaView Update(int id, EmpresaDto dto)
        {
            try
            {
                Empresa empresa = _repEmpresa.FindById<Empresa>(id) ?? throw new Exception($"Não foi possivél encontrar a empresa de ID = {id}.");
                empresa = new Empresa().AtualizaEmpresa(empresa, dto);
                _repEmpresa.SaveChanges(empresa);
                EmpresaView view = new(empresa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar empresa. Erro: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repEmpresa.DeleteById<Empresa>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar empresa. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repEmpresa.DeleteByIds<Empresa>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar empresa. Erro: {e.Message}");
            }
        }

        public EmpresaView FindById(int id)
        {
            try
            {
                Empresa empresa = _repEmpresa.FindById<Empresa>(id) ?? throw new Exception($"Não foi possivél encontrar o empresa de ID = {id}.");
                EmpresaView view = new(empresa);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar empresa. Erro: {e.Message}");
            }
        }

        public List<EmpresaView> FindAll()
        {
            try
            {
                List<Empresa> empresaes = _repEmpresa.FindAll<Empresa>();
                List<EmpresaView> view = new EmpresaView().ListEmpresaView(empresaes);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar empresaes. Erro: {e.Message}");
            }
        }
    }
}