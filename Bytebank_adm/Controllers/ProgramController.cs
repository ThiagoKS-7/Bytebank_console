using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank_adm.Funcionarios.controllers;
using Bytebank_adm.Funcionarios.models;
using Bytebank_adm.Funcionarios.views;
using Bytebank_adm.Repositories;

namespace Bytebank_adm.Controllers
{
    public class ProgramController
    {
        public void runProgram()
        {
            List<Colaborador> list = new List<Colaborador>();
            FuncionarioRepository fr = new FuncionarioRepository();
            FuncionarioController fc = new FuncionarioController();
            
            Console.WriteLine("Boas vindas ao Bytebank adm!\n");
            Console.WriteLine("LISTAGEM DE FUNCIONARIOS:");
            fc.listarFuncionarios(fr.getList(list));
            Console.WriteLine("TOTAL ANUAL DE BONIFICAÇÕES:");
            fc.getTotalBonificacoes(fr.getList(list));
        }
    }
}
