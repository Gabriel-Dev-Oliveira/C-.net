using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y, troca;

            Console.WriteLine("Digite dois Números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                troca = x;
                x= y;
                y= troca;
            }

            int soma = 0;

            for (int i = x+1; i <  y; i++){
                if (i % 2 != 0)
                {
                    soma = soma + 1;
                }
            }

            Console.WriteLine("Soma dos impares = " + soma);
        }
    }
}
