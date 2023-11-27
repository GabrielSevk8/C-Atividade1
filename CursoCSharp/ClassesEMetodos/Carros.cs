using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Carros {

        public string Marca;
        public string Modelo;
        public double VelMax;
        public double Autonomia;

        public string Apresentar() {
            return string.Format($"Marca: {Marca}; Modelo: {Modelo}; Velocidade Max: {VelMax}Km/h; Autonomia: {Autonomia}Km/l.");
        }

        public void ApresentarNoConsole() {
            //aqui estou chamando no console o método Apresentar()
            Console.WriteLine(Apresentar());
        }
    }
}

