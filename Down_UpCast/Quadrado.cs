using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownCast
{
    public class Quadrado : Forma
    {
        public int lados = 4;
        public override void Desenhar()
        {
            Console.WriteLine("Forma de quadrado!");
        }
    }
}
