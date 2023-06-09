﻿using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores.Models;
using MF.Domain.ControleMensal.Despesas;
using MF.Domain.ControleMensal.Rendas;

namespace MF.Domain.Commons.Consumirdores
{
    public class Consumidor : IdBaseDtAlt
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public decimal RendaTotal { get; private set; } = 0;
        public string? Celular { get; set; }

        public List<Renda> Rendas { get; set; }
        public List<Despesa> Despesas { get; set; }

        public void AtualizaRenda()
        {
            RendaTotal = Rendas?.Sum(x => x.Valor) ?? 0;
        }

        public Consumidor()
        {
        }

        public Consumidor(ConsumidorDto consumidor)
        {
            Nome = consumidor.Nome;
            Email = consumidor.Email;
            DataNascimento = consumidor.DataNascimento;
            Celular = consumidor.Celular;
            AtualizaRenda();
        }

        public Consumidor AtualizaConsumidor(Consumidor consumidor, ConsumidorDto consumidorDto)
        {
            consumidor.Nome = string.IsNullOrEmpty(consumidorDto.Nome) ? consumidor.Nome : consumidorDto.Nome;
            consumidor.Email = string.IsNullOrEmpty(consumidorDto.Email) ? consumidor.Email : consumidorDto.Email;
            consumidor.DataNascimento = consumidorDto.DataNascimento == null ? consumidor.DataNascimento : consumidorDto.DataNascimento;
            consumidor.Celular = string.IsNullOrEmpty(consumidorDto.Celular) ? consumidor.Celular : consumidorDto.Celular;
            AtualizaRenda();

            return consumidor;
        }
    }
}