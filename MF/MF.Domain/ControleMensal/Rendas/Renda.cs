﻿using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.Consumirdores;
using MF.Domain.Commons.Empresas;
using MF.Domain.ControleMensal.Rendas.Models;

namespace MF.Domain.ControleMensal.Rendas
{
    public class Renda : IdBaseDtAlt
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Salario { get; set; }

        public int? CodigoEmpresa { get; set; }
        public int? CodigoConsumidor { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Consumidor Consumidor { get; set; }

        public Renda()
        {
        }

        public Renda(RendaDto renda)
        {
            Descricao = renda.Descricao;
            Valor = renda.Valor;
            Salario = renda.Salario;
            CodigoEmpresa = renda.CodigoEmpresa;
            CodigoConsumidor = renda.CodigoConsumidor;
        }

        public Renda AtualizaRenda(Renda renda, RendaDto rendaDto)
        {
            renda.Descricao = rendaDto.Descricao;
            renda.Valor = rendaDto.Valor;
            renda.Salario = rendaDto.Salario;
            renda.CodigoEmpresa = rendaDto.CodigoEmpresa;
            renda.CodigoConsumidor = rendaDto.CodigoConsumidor;

            return renda;
        }
    }
}