﻿using MF.Domain.Commons.ClassesBase;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Models;
using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;

namespace MF.Domain.Commons.ModalidadePagto.CondPagtos
{
    public class CondPagto : IdBase
    {
        public string Descricao { get; set; }
        public bool Credito { get; set; }
        public int QuantParc { get; set; }

        public List<CondPagtoParcs>? Parcs { get; set; }

        public CondPagto()
        {
        }

        public CondPagto(CondPagtoDto condPagto)
        {
            Descricao = condPagto.Descricao;
            Credito = condPagto.Credito;
            QuantParc = condPagto.QuantParc;
        }

        public CondPagto AtualizaCondPagto(CondPagto condPagto, CondPagtoDto condPagtoDto)
        {
            condPagto.Descricao = condPagtoDto.Descricao;
            condPagto.Credito = condPagtoDto.Credito;
            condPagto.QuantParc = condPagtoDto.QuantParc;

            return condPagto;
        }
    }
}