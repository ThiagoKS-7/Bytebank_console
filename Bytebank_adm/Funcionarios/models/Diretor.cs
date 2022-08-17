using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    public class Diretor:Colaborador
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario, 1)
        {
            base.Usr = "diretor_";
            ValidaSalario(nome, cpf, salario, 1, 5000, (base.Usr + cpf.Substring(0, 7)), "U%*&4me");
        }


        public override void AumentarSalario(double porcentagem)
        {
            double res = porcentagem / 100;
            this.Salario *= (1.15 + res);
        }
    }
}
