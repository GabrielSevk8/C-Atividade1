using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {

            //criando um objeto a partir da classe Pessoa
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Alfredo";
            pessoa1.Idade = 95;
            pessoa1.Altura = 1.75;
            pessoa1.Peso = 80;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Angelica";
            pessoa2.Idade = 90;

            //exibindo os dados
            //Console.WriteLine($"Olá {pessoa1.Nome}, você tem {pessoa1.Idade} anos")

            pessoa1.ApresentarNoConsole();
            pessoa2.ApresentarNoConsole();

            Carros carro1 = new Carros();

            carro1.Marca = "Koenigsegg";
            carro1.Modelo = "Agera RS";
            carro1.VelMax = 447.19;
            carro1.Autonomia = 6.8;

            Carros carro2 = new Carros();

            carro2.Marca = "Bugatti";
            carro2.Modelo = "Chiron";
            carro2.VelMax = 490.48;
            carro2.Autonomia = 4.7;

            carro1.ApresentarNoConsole();
            carro2.ApresentarNoConsole();

        }
    }
}
