using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Produto(string nome, decimal valor, int quantidade)
    {
        public string Nome = nome;
        public decimal Valor = valor;
        public int Quantidade = quantidade;
    }
}
