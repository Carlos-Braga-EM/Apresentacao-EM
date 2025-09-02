using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Pessoa(string nome, int idade, string sexo, string cpf)
    {
        public string Nome = nome;
        public int Idade = idade;
        public string Sexo = sexo;
        public string CPF = cpf;
    }
}
