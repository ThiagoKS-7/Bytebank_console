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
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public double Salario { get; protected set; } //impede de fazer set do jeito errado
        public int Tipo { get; protected set; }
        public static int totalFuncionarios { get; private set; }
        /*=====================*/
            public Colaborador(string nome, string cpf, double salario, int _tipo)
        {
            ValidaSalario(nome, cpf, salario, _tipo, 2000);  
        }

        double FuncInterface.GetBonificacao()
        {
            return GetBonificacao();
        }

        string FuncInterface.TraduzTipo(int tipo)
        {
            return TraduzTipo(Tipo);
        }
        void FuncInterface.ValidaSalario(string nome, string cpf, double salario, int tipo, double salarioBase)
        {
            ValidaSalario(nome,cpf,salario,tipo,salarioBase);
        }
        public virtual double GetBonificacao()
        {
             return Salario;
        }

        public virtual void ValidaSalario(string nome, string cpf, double salario, int tipo, double salarioBase)
        {
            if (Salario >= salarioBase)
            {
                this.Nome = nome;
                this.Cpf = cpf;
                this.Salario = salario;
                this.Tipo = tipo;
            }
            else
            {
                this.Nome = nome;
                this.Cpf = cpf;
                this.Salario = salarioBase;
                this.Tipo = tipo;
            }
        }

        public string TraduzTipo(int tipo)
        {
            switch (tipo)
            {
                case 0:
                    return "Auxiliar";
                case 1:
                    return "Diretor";
                case 2:
                    return "Designer";
                case 3:
                    return "Gerente de Contas";
                default:
                    return "Tipo inválido";
            }
        }

        public virtual void AumentarSalario(double porcentagem)
        {
            double res = porcentagem / 100;
            this.Salario *= (1 + res) ;
            totalFuncionarios = 0;
        }
 
        public override string ToString()
        {
            totalFuncionarios++;
            return $"\nID:{totalFuncionarios}\nTipo: {TraduzTipo(Tipo)}\nNome: {Nome}\nCPF {Cpf}\nSalário: {Salario}\nBonificação: {GetBonificacao()}\n";
        }
    }
}
