using Bytebank_adm.Funcionarios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_adm.Funcionarios.models
{
    public class Colaborador: FuncInterface 
    {
        /*
         * a implementação de interface é o mesmo que herdar
         * uma classe abstrata aqui (só q a interface ñ implementa o método)
        */
        /*
        *   0 - funcionario
        *   1 - diretor
        *   2 - designer
        */

        /*Uso externo à classe (usar as privates aqui): */
        //atalho (prop + 2x tab)
        public string Nome { get; set; }
        public string Cpf { get; }
        public double Salario { get; }
        public int Tipo { get; }

        public static int totalFuncionarios { get; private set; }
        /*=====================*/

        public Colaborador(string nome, string cpf, double salario, int _tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            Tipo = _tipo;
        }

        double FuncInterface.getBonificacao()
        {
            return getBonificacao();
        }

        string FuncInterface.traduzTipo(int tipo)
        {
            return traduzTipo(Tipo);
        }
        public virtual double getBonificacao()
        {
             return Salario;
        }

        public string traduzTipo(int tipo)
        {
            switch (tipo)
            {
                case 0:
                    return "Desenvolvedor";
                case 1:
                    return "Diretor";
                case 2:
                    return "Designer";
                default:
                    return "Tipo inválido";
            }
        }

        public override string ToString()
        {
            totalFuncionarios++;
            return $"\nID:{totalFuncionarios}\nTipo: {traduzTipo(Tipo)}\nNome: {Nome}\nCPF {Cpf}\nSalário: {Salario}\nBonificação: {getBonificacao()}\n";
        }
    }
}
