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
            int idade;
            double salario, altura;
            char genero;
            string nome;

            CultureInfo CI = CultureInfo.InvariantCulture;

            idade = 32;
            salario = 4.974;
            altura = 1.79;
            genero = 'M';
            nome = "Guilherme alcantara";

            Double x = 1.36165;

            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(altura);
            Console.WriteLine(salario);
            Console.WriteLine(genero);

            //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F2", CI));
            // Da forma que não foi comentada deixa o código mais limpo



            Console.WriteLine("o funcionário: " + nome + ", idade: " + idade + ", salario: " + salario.ToString("F2", CI));
            // seguindo a lógica, sendo possivel colocar o restante das informações


        }
    }
}
