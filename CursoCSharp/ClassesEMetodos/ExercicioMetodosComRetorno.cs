using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    /* Exercicio Conversão para Dolar
    class RealDolar {

        public double Dolar(double real) {
            return real * 4.88;
        }
    }
    class ExercicioMetodosComRetorno {
        public static void Executar() {
            var RealDolar = new RealDolar();

            Console.WriteLine("Insira a quantidade para a conversão: ");
            double.TryParse(Console.ReadLine(), out double real);

            var resultado = RealDolar.Dolar(real);
            Console.WriteLine(resultado);
            
        }
    }
    */

    class ConvTemp {

        public double Fahr(double cel) {
            return (cel * 1.8)+32;
        }
    }
    class ExercicioMetodosComRetorno {
        public static void Executar() {
            var ConvTemp = new ConvTemp();

            Console.WriteLine("Insira a temperatura em °C: ");
            double.TryParse(Console.ReadLine(), out double cel);

            var resultado = ConvTemp.Fahr(cel);
            Console.WriteLine($"{resultado}°F");

        }
    }
}
