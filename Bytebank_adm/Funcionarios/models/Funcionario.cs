using System;
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
            base.Usr = "funcionario_";
            ValidaSalario(nome, cpf, salario, 4, 1800, (base.Usr + cpf.Substring(0, 7)), base.Senha);
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() * 0.12;
        }
    }
}
