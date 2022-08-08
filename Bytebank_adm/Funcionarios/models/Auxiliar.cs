using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    public class Auxiliar:Colaborador
    {
        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, salario, 0)
        {
            ValidaSalario(nome, cpf, salario, 0, 2000);
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() * 0.1;
        }
    }
}
