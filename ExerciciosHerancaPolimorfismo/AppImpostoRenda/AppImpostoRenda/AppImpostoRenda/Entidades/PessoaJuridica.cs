﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppImpostoRenda.Entidades
{
    class PessoaJuridica : ImpostoRenda
    {
        public int NumeroFuncionarios { get; set; }
        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        public override double CalculaImposto()
        {
            if(NumeroFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
