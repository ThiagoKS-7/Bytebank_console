using Bytebank_adm.Funcionarios.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Views
{
    public class MenuView
    {
        public void ShowMenu(Colaborador usr)
        {
            Console.WriteLine("\n\n" +
                "======= MENU PRINCIPAL =======\n\n" +
                "| 1 - Mudar senha; \n" +
                "| 2 - Detalhes da conta;"
                );
            if (usr.Usr.Substring(0,7) == "diretor"  || usr.Usr.Substring(0, 6) == "gestor")
            {
                Console.WriteLine(
                "| 3 - (ADM) Listar Funcionários; \n" +
                "| 4 - (ADM) Listar Saldos;\n" +
                "| 5 - (ADM) Listar Total anual de bonificações;\n" +
                "| 6 - (ADM) Dar aumento;"
                );
            }
            Console.WriteLine(
                "| 7 - Desologar;\n" +
                "| 0 - Sair;\n\n" +
                "===================\n\n");
        }
    }
}
