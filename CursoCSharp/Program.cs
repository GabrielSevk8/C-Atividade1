using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Formatando Numeros - Fundamentos",FormatandoNumeros.Executar},
                {"Operadores Aritmeticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Exercicios Operadores - Fundamentos",ExerciciosOperadores.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Atribuição - Fundamentos",OperadoresAtribuicao.Executar},
                {"Estruturas De Controle - Fundamentos",EstruturasDeControle.Executar},
                {"Exercicio If Else - Fundamentos",ExercicioIfElse.Executar},
                {"Try Parse - Fundamentos",TryParse.Executar},
                {"Estrutura Switch - Fundamentos",EstruturaSwitch.Executar},
                {"Estrutura While - Fundamentos",EstruturaWhile.Executar},
                {"Estrutura For - Fundamentos",EstruturaFor.Executar},
                {"Pratica Contador - Fundamentos",PraticaCont.Executar},
                {"Estrutura For Each - Fundamentos",EstruturaForEach.Executar},

                // Orientação a objetos - MÉTODOS
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Exercicio Métodos Com Retorno - Classes e Métodos",ExercicioMetodosComRetorno.Executar},
            }); 

            central.SelecionarEExecutar();
        }
    }
}