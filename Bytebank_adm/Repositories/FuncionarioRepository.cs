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
        public List<Colaborador> GetList(List<Colaborador> list)
        {
            list.Add(new Auxiliar("João Lima da Cunha", "123.456.678-53", 2054.42));
            list.Add(new Diretor("Paula Vieira Filho", "123.456.678-53", 522.70));
            list.Add(new Designer("Flávia Garcia", "123.456.678-53", 3830.90));
            list.Add(new Auxiliar("Ednaldo Pereira", "123.456.678-53", 2360.40));
            list.Add(new GerenteDeContas("Hogger Flux", "925.457.604-41", 4360.40));
            return list;
        }
    }
}
