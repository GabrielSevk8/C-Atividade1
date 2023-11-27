using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {

        //Estamos colocando o tipo public porque quero que esse atributo fique visivel para a minha classe

        public string Nome;
        public int Idade;
        public double Altura;
        public double Peso;

        //Criando um método
        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos");
        }
        //criando método vazio 
        public void ApresentarNoConsole() {
            //aqui estou chamando no console o método Apresentar()
            Console.WriteLine(Apresentar());
        }

    }
}
