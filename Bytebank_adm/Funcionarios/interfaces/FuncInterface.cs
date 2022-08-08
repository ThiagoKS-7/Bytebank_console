using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.interfaces
{
    public interface FuncInterface
    {
        public abstract double GetBonificacao();
        public abstract string TraduzTipo(int tipo);
        public abstract void ValidaSalario(string nome, string cpf, double salario, int tipo, double salarioBase);
    }
}
