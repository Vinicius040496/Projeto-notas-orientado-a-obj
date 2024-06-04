using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp127
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Al = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            Al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            Al.Nota1 = double.Parse(Console.ReadLine());
            Al.Nota2 = double.Parse(Console.ReadLine());
            Al.Nota3 = double.Parse(Console.ReadLine());
            Al.Media();
            Al.Aprovado();
            Console.WriteLine("Media do aluno: {0},", Al.Media());

            if (Al.Aprovado())
            {
                Console.WriteLine("Parabéns, Aluno Aprovado!!");
            }
            else
            {
                Console.WriteLine("Desculpe, Aluno Reprovado!");
            }
            Console.ReadLine();

        }
    }
}

