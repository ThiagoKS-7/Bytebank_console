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
        public List<Colaborador> getList(List<Colaborador> list)
        {
            list.Add(new("João", "123.456.678-53", 2054.42, 0));
            list.Add(new("Paula", "123.456.678-53", 5322.70, 1));
            list.Add(new("Flávia", "123.456.678-53", 3830.90, 2));
            list.Add(new("Ednaldo", "123.456.678-53", 2360.40, 0));
            return list;
        }
    }
}
