using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp127
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3 / 3;
        }

        public bool Aprovado()
        {
            if (Media() >= 15.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
