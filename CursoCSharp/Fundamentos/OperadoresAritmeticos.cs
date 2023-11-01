using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {

        public static void Executar() {

            /*
            Console.WriteLine("Insira o numero para a soma: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {n1+n2}");
            */

            Console.WriteLine("Escreva a Altura: ");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a Base: ");
            double B = double.Parse(Console.ReadLine());

            double resultado = B * A / 2;

            Console.WriteLine($"A area é igual a {resultado.ToString("#.#")}");
        }
    }
}
