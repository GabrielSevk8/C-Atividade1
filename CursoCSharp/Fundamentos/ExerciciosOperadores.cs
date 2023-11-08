using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExerciciosOperadores {

        public static void Executar() {

            /*Exercicio 1

            Console.WriteLine("Insira a primeira nota:");
            double n1 = double.Parse (Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;
            media = Math.Round(media, 2);

            Console.WriteLine($"A média é: {media}");
            */

            /*Exercicio 2

            const double peso1 = 3.5;
            const double peso2 = 7.5;

            Console.WriteLine("Insira a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 * peso1 + n2 * peso2) / (peso1 + peso2);
            media = Math.Round(media, 1);

            Console.WriteLine($"Resultado: {media}");
            */

            //Exercicio 3

            Console.WriteLine("Escreva o numero do funcionário: ");
            int numFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira as horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o salario/hora");
            double valorHoras = double.Parse(Console.ReadLine());

            double salario = horas * valorHoras;

            Console.WriteLine($"Número do funcionário:{numFunc}");
            Console.WriteLine($"Salário:R${salario}");







        }
    }
}
