﻿using MF.Domain.Commons.Consumirdores.Models;

namespace MF.Application.Commons.Consumirdores
{
    public interface IAplicConsumidor
    {
        void Delete(int id);
        List<ConsumidorView> FindAll();
        ConsumidorView FindById(int id);
        ConsumidorView Insert(ConsumidorDto dto);
        ConsumidorView Update(int id, ConsumidorDto dto);
    }
}