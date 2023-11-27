using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class PraticaCont {
        public static void Executar() {

            int soma = 0;

            for (int cont = 1; cont <= 10; cont++) {
                Console.WriteLine("Digite um numero");
                int.TryParse(Console.ReadLine(), out int num);

                soma += num;
            }

            Console.WriteLine($"A soma dos números é {soma}");
        }
    }
}
