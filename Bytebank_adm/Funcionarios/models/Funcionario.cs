﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    public class Funcionario:Colaborador
    {
        public Funcionario(string nome, string cpf, double salario) : base(nome, cpf, salario, 4)
        {
            ValidaSalario(nome, cpf, salario, 4, 1800);
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() * 0.12;
        }
    }
}
