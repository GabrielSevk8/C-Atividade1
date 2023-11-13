using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExercicioIfElse {
        public static void Executar() {

            /* Exercicio 1
            Console.WriteLine("Qual ano você nasceu? ");
            int anoNasc = int.Parse(Console.ReadLine());

            int idade = (2023 - anoNasc);

            if( idade >= 18 && idade <= 70) {
                Console.WriteLine("É obrigatório votar!");
            } else {
                Console.WriteLine("Votar é opcional!");
            }
            */

            /*Exercicio 2

            string senha = "7taz9HvJ";

            Console.WriteLine("Escreva a senha válida");
            string digiSenha = Console.ReadLine();

            if(digiSenha == senha){
                Console.WriteLine("Acesso Permitido!");
            } else {
                Console.WriteLine("Acesso Negado!");
            }
            */

            /*Exercicio 3

            Console.WriteLine("Digite a primeira nota");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            double n3 = double.Parse(Console.ReadLine());

            double result = (n1 + n2 + n3) / 3;

            if(result >= 7) {
                Console.WriteLine($"Sua nota é {result.ToString("#.##")}. Você passou!");
            } else if(result < 7 || result > 5){
                Console.WriteLine($"Sua nota é {result.ToString("#.##")}. Você está de recuperação!");
            } else {
                Console.WriteLine($"Sua nota é {result.ToString("#.##")}. Você esta reprovado!");
            }
            */

            // Exercicio 4
            Console.WriteLine("Escreva a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            if (IMC < 18.5) {
                Console.WriteLine("Abaixo do peso");
            }else if (IMC >= 18.5 && IMC <=24.9 ){
                Console.WriteLine("Peso normal");
            } else if (IMC >= 25 && IMC <= 29.9) {
                Console.WriteLine("Acima do peso");
            } else if (IMC >= 30 && IMC <= 34.9) {
                Console.WriteLine("Obesidade Grau I");
            } else if (IMC >= 35 && IMC <= 39.9) {
                Console.WriteLine("Obesidade Grau II");
            } else {
                Console.WriteLine("Obesidade Grau III");
            }

        } 
    }
}
