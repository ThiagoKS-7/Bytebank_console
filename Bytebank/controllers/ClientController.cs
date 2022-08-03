using Bytebank.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.controllers
{
    public class ClientController
    {
        public static Cliente[] getClients()
        {
            Cliente[] clientes = new Cliente[3];
            Cliente thiago = new Cliente("Thiago Kasper de Souza", "123.345.456-90", "dev");
            Cliente erica = new Cliente("Érica Oliveira Francisco", "123.345.456-90", "eng. prod.");
            Cliente dmy = new Cliente();

            clientes[0] = thiago;
            clientes[1] = erica;
            clientes[2] = dmy;

            return clientes;
        }
    }
}
