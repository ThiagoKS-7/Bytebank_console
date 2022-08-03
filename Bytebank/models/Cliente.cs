using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.models
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        public string Nome { get; }
        public string Cpf { get; }
        public string profissao;

        public Cliente()
        {
            nome = "Dummy name";
            cpf = "111.111.111-11";
            profissao = "dummy";
        }
        public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.profissao = profissao;
        }
    }
}
