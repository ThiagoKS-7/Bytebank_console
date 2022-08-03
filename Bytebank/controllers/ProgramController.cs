using Bytebank.models;
using Bytebank.views;

namespace Bytebank.controllers
{
    public class ProgramController
    {
        public static void runProgram()
        {
            Console.WriteLine("Boas vindas ao Bytebank!\n\n");
            Cliente[] clientes = ClientController.getClients();
            ContaCorrente[] contas = AccountController.setAccounts(clientes);
            ProgramView.showAccounts(contas);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
