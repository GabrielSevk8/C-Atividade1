using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {
            string nome = "Malcon";
            var sobreNome = "Batman"; // variavel coringa
            int idade = 38;
            double altura = 1.60;
            bool casado = false;

            idade = 40;

            const double pi = 3.14; // constante

            Console.WriteLine($"Olá, eu sou {nome}, eu tenho {idade} anos, tenho {altura} de altura");

        }
    }
}
