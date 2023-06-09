﻿namespace MF.Domain.Commons.Usuarios
{
    public interface IRepUsuario : IRep<Usuario>
    {
        Usuario FindByLoginOrEmail(string email, string login);
    }
}