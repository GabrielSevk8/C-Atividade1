using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Cliente {

        public string Nome;
        public string Cpf;
        public string Endereco;
        public string Sexo;
        public int Idade;

        //criando o construtor personalizado de Cliente
        public Cliente(string nome, string cpf, string endereco, string sexo, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }

        //construtor padrão
        public Cliente() {

        }

    }
    class Construtores {
        public static void Executar() {

            //Fazendo instancia / objeto
            var cliente1 = new Cliente();
            //Criando os Atributos
            cliente1.Nome = "Jeferson";
            cliente1.Cpf = "23245467689";
            cliente1.Sexo = "M";
            cliente1.Endereco = "Clube de Campo";
            cliente1.Idade = 50;

            var cliente2 = new Cliente("Douglas", "112345678", "M", "Santa Paula", 18);

            var cliente3 = new Cliente() {
                Nome = "Marlin",
                Sexo = "F",
                Endereco = "Jardim Santo André",
                Idade = 28,
            };

            Console.WriteLine($"Nome: {cliente1.Nome} CPF: {cliente1.Cpf}");


        }
    }
}
