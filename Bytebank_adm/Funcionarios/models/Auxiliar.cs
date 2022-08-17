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
            base.Usr = "auxiliar_";
            ValidaSalario(nome, cpf, salario, 0, 2000, (base.Usr + cpf.Substring(0, 7)), base.Senha);
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() * 0.1;
        }
    }
}
