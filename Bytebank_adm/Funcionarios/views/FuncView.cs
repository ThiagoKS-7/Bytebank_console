using Bytebank_adm.Funcionarios.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.views
{
    public class FuncView
    {
        public void showFuncionarios(List<Colaborador> list)
        {
            foreach (Colaborador i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void showTotalBonificacoes(double total)
        {
            Console.WriteLine($"Total no ano: R$ {total}");
        }
    }
}
