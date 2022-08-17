using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    public class GerenteDeContas:Colaborador
    {


        public GerenteDeContas(string nome, string cpf, double salario) : base(nome, cpf, salario,3)
        {
            base.Usr = "gerente_";
            ValidaSalario(nome, cpf, salario, 3, 4000, (base.Usr + cpf.Substring(0, 7)), "I%*&2yP");
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() * 0.25;
        }

        public override void AumentarSalario(double porcentagem)
        {
            double res = porcentagem / 100;
            this.Salario *= (1.05 + res);
        }
    }
}
