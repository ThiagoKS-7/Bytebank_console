using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank_adm.Funcionarios.controllers;
using Bytebank_adm.Funcionarios.models;
using Bytebank_adm.Funcionarios.views;
using Bytebank_adm.Repositories;
using Bytebank_adm.SistemaInterno;

namespace Bytebank_adm.Controllers
{
    public class ProgramController
    {
        public void runProgram()
        {
            List<Colaborador> list = new List<Colaborador>();
            FuncionarioRepository fr = new FuncionarioRepository();
            List<Colaborador> funcionarios = fr.GetList(list);
            Auth auth = new Auth();
            bool logged = false;
            Console.WriteLine("Boas vindas ao Bytebank adm!\n");
            auth.Login(funcionarios, logged);
            /*
            funcionarios[0].AumentarSalario(10);
            funcionarios[1].AumentarSalario(10);
            Console.WriteLine("\n\nFUNCIONARIOS PÓS AUMENTO:\n");
            fc.ListarSaldos(funcionarios);
            */
        }
    }
}
