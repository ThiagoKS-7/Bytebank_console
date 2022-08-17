using Bytebank_adm.Funcionarios.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Repositories
{
    public class FuncionarioRepository
    {
        dynamic[] colaboradores =
        {
            new Diretor("Paula Vieira Filho", "019.977.980-50", 522.70),
            new GerenteDeContas("Hogger Flux", "231.399.980-74", 4360.40),
            new Auxiliar("João Lima da Cunha", "064.311.690-77", 2054.42),
            new Designer("Flávia Garcia", "247.822.930-70", 3830.90),
            new Auxiliar("Ednaldo Pereira", "966.046.970-53", 2360.40),
        };
        public List<Colaborador> GetList(List<Colaborador> list)
        {
            for (int i = 0; i < colaboradores.Length; i ++)
            {
                list.Add(colaboradores[i]);
            }
            return list;
        }
    }
}
