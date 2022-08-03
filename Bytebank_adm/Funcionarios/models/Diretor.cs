using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    public class Diretor:Colaborador
    {

        public Diretor(string nome, string cpf, double salario, int tipo) : base(nome, cpf, salario, tipo)
        {
            Colaborador cb = new(nome, cpf, salario, tipo);
        }

    }
}
