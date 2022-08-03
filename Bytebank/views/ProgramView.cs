using Bytebank.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.views
{
    public class ProgramView
    {
        private static void ShowInfo(ContaCorrente conta)
        {
            Console.WriteLine(
            $"Nome: {conta.cliente.Nome}\n" +
            $"Conta: {conta.Conta}\n" +
            $"Agência: {conta.Agencia}\n" +
            $"Nome agência: {conta.nome_agencia}\n" +
            $"Saldo: {conta.Saldo}\n");
        }

        public static void showAccounts(ContaCorrente[] contas)
        {
            Console.WriteLine("==================== CONTAS EXISTENTES ===================\n\n");
            ShowInfo(contas[0]);
            ShowInfo(contas[1]);
            ShowInfo(contas[2]);
            Console.WriteLine("==================== // ===================\n\n");
            contas[1].Sacar(50);
            contas[2].Depositar(100);
            contas[0].Transferir(contas[1], 150);
        }
    }
}
