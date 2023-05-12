using MF.Application.Commons.Consumirdores;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.Commons.Usuarios;
using MF.Domain.Commons.Usuarios.Email;
using MF.Domain.Commons.Usuarios.Models;
using MF.Domain.Commons.Usuarios.Validacoes;
using System.Net;
using System.Net.Mail;

namespace MF.Application.Commons.Usuarios
{
    public class AplicUsuario : IAplicUsuario
    {
        private readonly IRepUsuario _repUsuario;
        private readonly IValidacoesUsuario _validacoesUsuario;
        private readonly IAplicConsumidor _aplicConsumidor;
        private readonly IRepEmailProvider _repEmailProvider;

        public AplicUsuario(IRepUsuario repUsuario,
                            IValidacoesUsuario validacoesUsuario,
                            IAplicConsumidor aplicConsumidor,
                            IRepEmailProvider repEmailProvider)
        {
            _repUsuario = repUsuario;
            _validacoesUsuario = validacoesUsuario;
            _aplicConsumidor = aplicConsumidor;
            _repEmailProvider = repEmailProvider;
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
            bool atualizaConsumidor = false;
            string emailAnterior = "";

            try
            {
                usuario = _repUsuario.FindById<Usuario>(id) ?? throw new Exception($"Não foi possivél encontrar o usuario de ID = {id}.");

                if (usuario.Login.Trim().ToUpper() != dto.Login.Trim().ToUpper())
                    _validacoesUsuario.ValidaLoginUnico(dto);

                if (usuario.Email.Trim().ToUpper() != dto.Email.Trim().ToUpper())
                    _validacoesUsuario.ValidaEmailUnico(dto);

                if (usuario.Nome.Trim().ToUpper() != dto.Nome.Trim().ToUpper() || usuario.Email.Trim().ToUpper() != dto.Email.Trim().ToUpper())
                {
                    atualizaConsumidor = true;
                    emailAnterior = usuario.Email;
                }

                usuario = new Usuario().AtualizaUsuario(usuario, dto);
                _repUsuario.SaveChanges(usuario);
                view = new(usuario);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao alterar usuario. Erro: {e.Message}");
            }

            if (!atualizaConsumidor)
                return view;

            try
            {
                var consumidor = _aplicConsumidor.FindByEmail(emailAnterior);

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

        public void RecuperarSenha(string? login, string? email)
        {
            try
            {
                ValidaEmailOuLogin(login, email);

                Usuario usuario = _repUsuario.FindByLoginOrEmail(email, login);

                try
                {
                    EnviarEmailRecuperaçãoSenha(usuario.Nome, usuario.Email);
                }
                catch (Exception e)
                {
                    throw new Exception($@"Erro ao enviar E-mail de recuperação de senha! Erro: {e.Message} {e.InnerException}");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void ValidaEmailOuLogin(string? login, string? email)
        {
            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(email))
                throw new Exception("Email e login inválidos! Por favor, forneça uma das informações.");
        }

        private void EnviarEmailRecuperaçãoSenha(string nomeUser, string emailUser)
        {
            EmailProvider emailProvider = _repEmailProvider.FindAll<EmailProvider>().FirstOrDefault();

            var fromAddress = new MailAddress(emailProvider.Email, "Mestre das Finanças");
            var toAddress = new MailAddress(emailUser, nomeUser);

            MailMessage mensagem = new(fromAddress, toAddress)
            {
                Subject = "Recuperação de senha",

                // Configurar o corpo da mensagem em formato HTML
                IsBodyHtml = true,
                Body = $@"
                <html>
                <body>
                    <h3>Olá, {nomeUser}!</h3>
                    <p>Recebemos uma solicitação de recuperação de senha para a sua conta. Se você não solicitou esta recuperação, por favor, ignore este e-mail.</p>
                    <p>Para redefinir sua senha, clique no link abaixo e siga as instruções:</p>
                    <p><a href=""https://www.exemplo.com/recuperarsenha?token=123456"">Redefinir senha</a></p>
                    <p>Se você não conseguir clicar no link, copie e cole o endereço completo em seu navegador.</p>
                    <br />
                    <p>Atenciosamente,</p>
                    <p>Equipe Exemplo</p>
                </body>
                </html>
            "
            };

            // Configurar as credenciais e informações do servidor SMTP
            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, emailProvider.Senha)
            };

            // Enviar a mensagem de e-mail
            smtp.Send(mensagem);
        }

        public void AlterarSenha(string email, string senha, string senhaRepetida)
        {
            if (!senha.ToUpper().Trim().Equals(senhaRepetida.ToUpper().Trim()))
                throw new Exception("As senhas digitadas são diferentes. Por favor, verifique e tente novamente.\r\n");

            Usuario usuario = _repUsuario.FindByLoginOrEmail(email, "");

            usuario.Senha = senha;
            _repUsuario.SaveChanges(usuario);
        }
    }
}