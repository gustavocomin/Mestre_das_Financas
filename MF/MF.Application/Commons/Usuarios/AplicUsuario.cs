using MF.Application.Commons.Consumirdores;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.Commons.Usuarios;
using MF.Domain.Commons.Usuarios.Models;
using MF.Domain.Commons.Usuarios.Validacoes;

namespace MF.Application.Commons.Usuarios
{
    public class AplicUsuario : IAplicUsuario
    {
        private readonly IRepUsuario _repUsuario;
        private readonly IValidacoesUsuario _validacoesUsuario;
        private readonly IAplicConsumidor _aplicConsumidor;

        public AplicUsuario(IRepUsuario repUsuario,
                            IValidacoesUsuario validacoesUsuario,
                            IAplicConsumidor aplicConsumidor)
        {
            _repUsuario = repUsuario;
            _validacoesUsuario = validacoesUsuario;
            _aplicConsumidor = aplicConsumidor;
        }

        public UsuarioView Insert(UsuarioCadastroDto dto)
        {
            UsuarioView view = new();
            Usuario usuario = new();
            try
            {
                _validacoesUsuario.ValidaLoginUnico(dto);
                _validacoesUsuario.ValidaEmailUnico(dto);

                usuario = new(dto);

                _repUsuario.SaveChanges(usuario);
                view = new(usuario);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir usuario. Erro: {e.Message} - {e.InnerException}");
            }

            try
            {
                ConsumidorDto consumidor = new Usuario().CriaConsumidor(dto);
                _aplicConsumidor.Insert(consumidor);
            }
            catch (Exception)
            {
                Delete(usuario.Id);
                throw new Exception($"Erro ao cadastrar consumidor para o usuário. Usuario de Login: {dto.Login} será excluído.");
            }

            return view;
        }

        public UsuarioView Update(int id, UsuarioCadastroDto dto)
        {
            Usuario usuario = new();
            UsuarioView view = new();

            try
            {
                _validacoesUsuario.ValidaLoginUnico(dto);
                _validacoesUsuario.ValidaEmailUnico(dto);

                usuario = _repUsuario.FindById<Usuario>(id) ?? throw new Exception($"Não foi possivél encontrar o usuario de ID = {id}.");
                usuario = new Usuario().AtualizaUsuario(usuario, dto);
                _repUsuario.SaveChanges(usuario);
                view = new(usuario);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar usuario. Erro: {e.Message}");
            }

            try
            {
                var consumidor = _aplicConsumidor.FindByEmail(usuario.Email);

                ConsumidorDto consumidorDto = new()
                {
                    Nome = usuario.Nome,
                    Email = usuario.Email
                };

                _aplicConsumidor.Update(consumidor.Id, consumidorDto);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao atualizar Email e Nome do consumidor. Erro: {e.Message}");
            }

            return view;
        }

        public void Delete(int id)
        {
            try
            {
                _repUsuario.DeleteById<Usuario>(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar usuario. Erro: {e.Message}");
            }
        }

        public void Delete(List<int> ids)
        {
            try
            {
                _repUsuario.DeleteByIds<Usuario>(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar usuarios. Erro: {e.Message}");
            }
        }

        public UsuarioView FindById(int id)
        {
            try
            {
                Usuario usuario = _repUsuario.FindById<Usuario>(id) ?? throw new Exception($"Não foi possivél encontrar o usuario de ID = {id}.");
                UsuarioView view = new(usuario);
                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar usuario. Erro: {e.Message}");
            }
        }

        public List<UsuarioView> FindAll()
        {
            try
            {
                List<UsuarioView> view = new();
                List<Usuario> usuarios = _repUsuario.FindAll<Usuario>();
                if (usuarios != null && usuarios.Count > 0)
                    view = new UsuarioView().ListUsuarioView(usuarios);

                return view;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar usuarios. Erro: {e.Message}");
            }
        }
    }
}