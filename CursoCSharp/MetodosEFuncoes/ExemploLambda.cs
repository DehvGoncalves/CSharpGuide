using System;
using System.Collections.Generic;

namespace CursoCSharp.MetodosEFuncoes {
    public class ExemploLambda {
        public static void Executar() {
            /* Action: É o tipo delegado, que representa um método que não retorna nenhum valor.É UMA FUNÇÃO QUE NÃO TEM RETORNO, TODO ACTION NÃO TERÁ RETORNO, DIFERENTE DO Func QUE É UMA ALTERNATIVA COM RETORNO
             * AlgoNoConsole: É o nome da variável que receberá a expressão lambda.
             * (): Indica que a expressão lambda não recebe nenhum parâmetro. Se houvesse parâmetros, eles seriam listados entre parênteses aqui.
             *👉🏻 =>: É o operador de LAMBDA, que separa os parâmetros da expressão.
             * { }: É o corpo da função lambda, onde está contida a lógica que será executada quando a expressão lambda for invocada.
             * Dentro das chaves { }, você pode incluir qualquer código que desejar executar quando a expressão lambda for chamada. Por exemplo:*/


            //LAMBDA
            //LAMBDA É UMA FUNÇÃO ANÔNIMA, ARMAZENADA EM UMA VARIÁVEL E VC VAI CHAMAR ESSA FUNÇÃO A PARTIR DO NOME DESSA VARIÁVEL
            //A FUNÇÃO É OQUE TÁ DEPOIS DO =, DO SIMBOLO DE ATRIBUIÇÃO

            /*() => { AQUI EU TENHO UMA FUNÇÃO ANONIMA, SENDO ARMAZENADA NA VARIÁVEL AlgoNoConsole0 QUE É DO TIPO ACTION
                Console.WriteLine("Lambda com C#");
            };*/

            Action AlgoNoConsole0 = () => {
                Console.WriteLine("Lambda com C#");
            };

            //LAMBDA 1
            Action AlgoNoConsole = () => {
                int resultado;
                int a = 2; int b = 3;
                resultado = a + b;
                Console.WriteLine(resultado);
            };

            //LAMBDA 2
            Action AlgoNoConsole2 = () => {
                Console.WriteLine("Executando algo no console");
            };

            //LAMBDA Action com parametro (Action não tem retorno)
            Action<String> AlgoNoConsole3 = (a) => {
                Console.WriteLine("Lambda em C#" + a);
            };

            //LAMBDA COM RETORNO 0 - Func

            /*Isso significa que você está criando uma função anônima que não recebe parâmetros e retorna um inteiro. 
             * O código dentro das chaves {} é o corpo dessa função, que cria um objeto Random, gera um número aleatório entre 1 e 6 e o retorna
             * Random é uma classe usada para gerar números aleatórios em c#
             */
            Func<int> JogarDado = () => {
                Random radom = new Random();
                return radom.Next(1, 7);
            };

            //LAMBDA COM RETORNO (Func) 0
            // Define uma função anônima que converte um número inteiro para sua representação hexadecimal como string.
            // O parâmetro "numero" é o número inteiro que será convertido.
            // A expressão lambda (numero => OieeeekkNumero.ToString("X")) recebe o número como entrada e retorna sua representação hexadecimal.
            // Define uma função anônima que converte um número inteiro para sua representação hexadecimal como string.
            Func<int, string> conversorHex = numero => numero.ToString("X");

            //PODE SER FEITA EM UMA LINHA, OU ASSIM
            Func<int, string> conversorHex1 = (num) => {
                return num.ToString("X");
            };

            //FUNÇÃO QUE RECEBE 3 INTEIROS E RETORNA UMA STRING
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            // Chamando as expressões lambda para mostrar os resultados no console
            //ACTION
            AlgoNoConsole0(); //Atction não precisa do cw pra mostrar na tela
            AlgoNoConsole();
            AlgoNoConsole2();
            AlgoNoConsole3(" com parâmetro");

            //FUNC
            Console.WriteLine($"Numero sorteado: {JogarDado()}");//Se for Func, pra mostrar na tela só pelo cw
            Console.WriteLine(conversorHex(1234));
            Console.WriteLine(conversorHex1(100));
            Console.WriteLine(formatarData(6, 3, 24));
        }
    }

}

