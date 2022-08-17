using Bytebank_adm.Controllers;
using Bytebank_adm.Funcionarios.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.SistemaInterno
{
    public class Auth
    {
        public Auth()
        {

        }
        public void Login(List<Colaborador> userList, bool logged)
        {
            while (!logged)
            {
                Console.WriteLine("\n\n========== LOGIN ==========\n");
                Console.Write("Digite o seu nome de usuário: ");
                string usr = Console.ReadLine();
                Console.Write("Digite a sua senha de usuário: ");
                string pwd = Console.ReadLine();
                foreach (Colaborador user in userList)
                {
                    if (user.Usr == usr && user.Senha == pwd)
                    {
                        Console.WriteLine("\nLogado!\n");
                        logged = true;
                        MenuController mc = new MenuController();
                        mc.RunMenu(user, userList, logged);
                    }
                }
                if (!logged)
                {
                    Console.WriteLine("\nLogin incorreto!");
                }
            }
        }
    }
}
