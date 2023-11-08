using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class EstruturasDeControle {
        public static void Executar() {

            /*
            double dinheiro = 8000;

            if(dinheiro > 5000) {
                Console.WriteLine("Posso Viajar");
            } else {
                Console.WriteLine("Não posso viajar!");
            }
            */

            Console.WriteLine("Insira a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if(media >= 7) {
                Console.WriteLine("Você foi aprovado!");
            } else {
                Console.WriteLine("Você reprovou!");
            }
        }
    }
}
