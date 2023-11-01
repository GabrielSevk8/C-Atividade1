using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {

        public static void Executar() {
            //Arredondar numero
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));

            //Transformar um valor monetário (moeda de acordo com idioma da máquina)
            Console.WriteLine(valor.ToString("C"));

            //multiplicar um valor por 100 e adiciona percentual
            Console.WriteLine(valor.ToString("P"));

            //Formatando o número do jeito que você quiser
            Console.WriteLine(valor.ToString("#.##"));
        }
    }
}
