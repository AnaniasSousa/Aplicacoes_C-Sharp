using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a LARGURA do comodo?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a PROFUNDIDADE do comodo?");
            double profundidade = double.Parse(Console.ReadLine());

            Calculadora calculadora = new Calculadora();


            Console.WriteLine("A área das PAREDES é igual a:");
            const double Altura = 2.9;
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura));

            Console.WriteLine("A área do TETO é igual a:");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade));


            Console.WriteLine("A litragem de tinta necessária é:");
            Console.WriteLine(calculadora.CalcularLitragemNecessaria());


            Console.ReadLine();
        }
    }
}