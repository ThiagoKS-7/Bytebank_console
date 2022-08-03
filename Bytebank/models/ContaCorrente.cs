using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PRECISA ESPECIFICAR O NAMESPACE
namespace Bytebank.models
{
    public class ContaCorrente
    {
        public Cliente cliente;
        public string nome_agencia;
        private double saldo;
        public string Conta { get; }
        public int Agencia { get; }
        public double Saldo { get; }

        /* 
         * Construtor sem atributo: faz com que a classe tenha valores padrão customizados
         */
        public ContaCorrente(Cliente cliente)
        {
            this.cliente = cliente;
            Conta = "1234";
            nome_agencia = "ag. teste";
        }
        /* 
         * Construtor com atributo: faz com que se possa setar os atributos do objeto direto na construção dele
         */
        public ContaCorrente(Cliente titular, string conta, int numero_agencia, string nome_agencia, double saldo)
        {
            cliente = titular;
            this.Conta = conta;
            this.Agencia = numero_agencia;
            this.nome_agencia = nome_agencia;
            if (saldo < 0)
            {
                this.saldo = 0;
            } else
            {
                this.saldo = saldo;
            }
        }

        /* 
         * MÉTODOS DA CLASSE
         */
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"Erro! {cliente.Nome} tem saldo insuficiente para o saque!\n");
                return false;
            }
            saldo -= valor;
            Console.WriteLine(
                $"R$ {valor} de {cliente.Nome}\n" +
                $"Sacados com sucesso!\n" +
                $"Conta: {Conta} - Agência: {Agencia}, {nome_agencia}\n" +
                $"Saldo: R${saldo}\n");
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine(
                $"R$ {valor} de {cliente.Nome}\n" +
                $"Depositados com sucesso!\n" +
                $"Conta: {Conta} - Agência: {Agencia}, {nome_agencia}\n" +
                $"Saldo: R${saldo}\n");
        }

        public void Transferir(ContaCorrente conta2, double valor)
        {
            if (saldo >= valor)
            {
                Console.WriteLine($"==================== TRANSFERINDO R$ {valor} ===================");
                Sacar(valor);
                conta2.Depositar(valor);
                Console.WriteLine($"==================== TRANSFERÊNCIA BEM SUCEDIDA ================");
            }
            else
            {
                Console.WriteLine($"Erro! {cliente.Nome} tem saldo insuficiente pra transferir.\n");
            }
        }
        /* Se fosse o caso se precisar getar e setar:
         * public double Saldo {
         *      get 
         *      {
         *          return saldo;
         *      }
         *      set
         *      {
         *          if (value < 0)
         *          {
         *              return;
         *          }
         *          saldo = value;
         *      }
         * funciona pros outros gets acima também.
         * 
         * static - faz um contador levar a classe como referencia, por exemplo
         */
    }
}
