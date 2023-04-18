﻿using MF.Domain.Commons.ClassesBase;
using MF.Domain.ControleMensal.Despesas;
using MF.Domain.ControleMensal.Rendas;

namespace MF.Domain.Commons.Consumirdores
{
    public class Consumidor : IdBaseDtAlt
    {
        public Consumidor()
        {
            AtualizaRenda();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        private decimal RendaTotal { get; set; }

        public List<Renda>? Rendas { get; set; }
        public List<Despesa>? Despesas { get; set; }


        public void AtualizaRenda()
        {
            RendaTotal = Rendas?.Sum(x => x.Valor) ?? 0;
        }
    }
}