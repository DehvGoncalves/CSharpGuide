using System;

namespace CursoCSharp.MetodosEFuncoes {
    internal class DelegatesComoParametros {

        // delegate do tipo inteiro, chamado Operacoes com dois parametros inteiros
        public delegate int Operacoes(int x, int y);

        public static int Soma(int x, int y) {
            return x + y; // metodo comum com retorno
        }

        // método comum, com um dos parâmetros chamado op, do tipo Operacoes que é um delegate, 
        public static string Calculadora(Operacoes op, int x, int y) {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }

        public static void Executar() {
            // Criação de uma instância do delegate 'Operacao' chamada 'subtracao'.
            // 'subtracao'  referencia a expressão lambda que subtrai dois números inteiros.
            Operacoes subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3, 2));

            Console.WriteLine(Calculadora(Soma, 3, 2));

        }
    }
}
