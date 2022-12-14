using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    
    public class Designer:Colaborador
    {
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario, 2)
        {
            base.Usr = "designer_";
            ValidaSalario(nome, cpf, salario, 2, 3000, (base.Usr+ cpf.Substring(0, 7)), base.Senha);
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() * 0.17;
        }

        public override void AumentarSalario(double porcentagem)
        {
            double res = porcentagem / 100;
            this.Salario *= (1.11 + res);
        }

    }
}
    