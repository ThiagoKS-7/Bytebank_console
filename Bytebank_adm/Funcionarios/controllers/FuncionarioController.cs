using Bytebank_adm.Funcionarios.models;
using Bytebank_adm.Funcionarios.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.controllers
{
    public class FuncionarioController
    {
        private List<Colaborador>? list;
        private List<Colaborador> getTipo(List<Colaborador> funcionarios)
        {
            List<Colaborador> list = new List<Colaborador>();
            foreach (Colaborador i in funcionarios)
            {
                if (i.Tipo == 1)
                {
                    Diretor dr = new Diretor(i.Nome, i.Cpf, i.Salario, i.Tipo);
                    list.Add(dr);
                }
                else
                {
                    Funcionario fr = new Funcionario(i.Nome, i.Cpf, i.Salario, i.Tipo);
                    list.Add(fr);
                }
            }
            return list;
        }
        public void getTotalBonificacoes(List<Colaborador> funcionarios)
        {
            double total = 0;
            FuncView fv = new FuncView();
            foreach (Colaborador i in list)
            {
                total += i.getBonificacao(); 
            }
            fv.showTotalBonificacoes(total);
        }
        public void listarFuncionarios(List<Colaborador> funcionarios)
        {
            FuncView fv = new FuncView();
            list = getTipo(funcionarios);
            fv.showFuncionarios(list);
        }
    }
}
