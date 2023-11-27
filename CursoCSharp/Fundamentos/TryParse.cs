using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class TryParse {
        public static void Executar() {
            Console.WriteLine("Digite um numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");
            //converta palavra e jogue dentro da variavel número
        }
    }
}
