using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMatri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor da aniudade: ");
            double anual = double.Parse(Console.ReadLine());
            double mensalidade = anual / 12;
            Console.WriteLine("informe o valor da matrícula: ");
            double matri = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor do material: ");
            double material = double.Parse(Console.ReadLine());

            int cont = 1;
            while (cont <= 12) 
            {
                if (cont == 1) {
                Console.WriteLine("Mensalidade: " +  cont + "valor: ");
                }
            }
        }
    }
}
