using Bytebank_adm.Funcionarios.controllers;
using Bytebank_adm.Funcionarios.models;
using Bytebank_adm.SistemaInterno;
using Bytebank_adm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Controllers
{
    public class MenuController
    {
        public void RunMenu(Colaborador usr, List<Colaborador> funcionarios, bool logged)
        {
            MenuView mv = new MenuView();
            FuncionarioController fc = new FuncionarioController();
            string i = "-1";
            do
            {
                mv.ShowMenu(usr);
                Console.Write("Digite uma das opções: ");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        Console.Write("\nDigite sua nova senha: ");
                        string senha = Console.ReadLine();
                        usr.ChangePassword(senha);
                        break;
                    case "2":
                        Console.WriteLine(usr);
                        break;
                    case "3":
                        Console.WriteLine("\nLISTAGEM DE FUNCIONARIOS:");
                        fc.ListarFuncionarios(funcionarios);
                        break;
                    case "4":
                        Console.WriteLine("\nLISTAGEM DE SALDOS:");
                        fc.ListarSaldos(funcionarios);
                        break;
                    case "5":
                        Console.WriteLine("\nTOTAL ANUAL DE BONIFICAÇÕES:");
                        fc.GetTotalBonificacoes(funcionarios);
                        break;
                    case "6":
                        Console.Write("\nDigite o nome do usuário: ");
                        string benef = Console.ReadLine();
                        foreach (Colaborador user in funcionarios)
                        {
                            if (user.Usr == benef)
                            {
                                Console.Write("\nDigite o valor do aumento: ");
                                double salary = Console.Read();
                                user.AumentarSalario(salary);
                                Console.Write("\n\nSalário aumentado com sucesso!\n");
                            }
                        }
                        break;
                    case "7":
                        logged = false;
                        Auth auth = new Auth();
                        auth.Login(funcionarios, logged);
                        break;
                    case "0":
                        Console.WriteLine("\n\nPrograma encerrado!\n\n");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n\nOpção inválida!\n\n");
                        break;

                }
            } while  (i != "0") ;
        }
    }
}
