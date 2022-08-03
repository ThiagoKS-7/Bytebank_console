using Bytebank.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.controllers
{
    public class AccountController
    {
        public static ContaCorrente[] setAccounts(Cliente[] clientes)
        {
            ContaCorrente[] contas = new ContaCorrente[3];
            ContaCorrente conta1 = new ContaCorrente(
                clientes[0],
                "10123-x",
                23,
                "Agencia central",
                903.50);
            ContaCorrente conta2 = new ContaCorrente(
                clientes[1],
                "10124-x",
                24,
                "Agencia central",
                903.50);
            ContaCorrente conta3 = new ContaCorrente(clientes[2]);
            contas[0] = conta1;
            contas[1] = conta2;
            contas[2] = conta3;
            return contas;
        }
    }
}
