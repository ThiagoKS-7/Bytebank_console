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
        private List<Colaborador> GetTipo(List<Colaborador> funcionarios)
        {
            List<Colaborador> list = new List<Colaborador>();
            foreach (Colaborador i in funcionarios)
            {
                switch(i.Tipo)
                {
                    case 0:
                        list.Add(new Auxiliar(i.Nome, i.Cpf, i.Salario));
                        break;
                    case 1:
                        list.Add(new Diretor(i.Nome, i.Cpf, i.Salario));
                        break;
                    case 2:
                        list.Add(new Designer(i.Nome, i.Cpf, i.Salario));
                        break;
                    case 3:
                        list.Add(new GerenteDeContas(i.Nome, i.Cpf, i.Salario));
                        break;
                    default:
                        list.Add(new Funcionario(i.Nome, i.Cpf, i.Salario));
                        break;
                }
               
            }
            return list;
        }
        public void GetTotalBonificacoes(List<Colaborador> funcionarios)
        {
            double total = 0;
            FuncView fv = new FuncView();
            foreach (Colaborador i in list)
            {
                total += i.GetBonificacao(); 
            }
            fv.ShowTotalBonificacoes(total);
        }
        public void ListarFuncionarios(List<Colaborador> funcionarios)
        {
            FuncView fv = new FuncView();
            list = GetTipo(funcionarios);
            fv.ShowFuncionarios(list);
        }

        public void ListarSaldos(List<Colaborador> funcionarios)
        {
            FuncView fv = new FuncView();
            list = GetTipo(funcionarios);
            fv.ShowFuncionarios(list);
        }
    }
}
