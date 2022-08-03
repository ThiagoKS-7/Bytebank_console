using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.interfaces
{
    public interface FuncInterface
    {
        double getBonificacao();
        string traduzTipo(int tipo);
    }
}
