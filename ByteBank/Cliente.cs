using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        public string nome { get; set; }
        public string profissao { get; set; }
        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }

        public Cliente(string nome, string profissao, string cpf)
        {
            this.nome = nome;
            this.profissao = profissao;
            CPF = cpf;
        }

    }
}
