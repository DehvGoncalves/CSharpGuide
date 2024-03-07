using System;

namespace CursoCSharp.MetodosEFuncoes {

    //LAMBDAS DELEGATES NADA MAIS É DO QUE VOCÊ DEFINIR UM TIPO QUE ARMAZENA UMA ASSINATURA DE UMA FUNÇÃO. ASSIM, VC CRIA UMA FORMA DE 
    //REUTILIZALAS COM A MESMA ASSINATURA


    // Declaração de um delegate chamado Operacao que representa uma função que recebe dois parâmetros do tipo double e retorna um double
    delegate double Operacao(double x, double y); //Operação é um tipo que eu acabei de criar
    public class LambdasDelegate {
        public static void Executar() {

            //O tipo já foi definido pelo Delegate, ambos serão dablo. O nome do tipo é operação conforme eu criei agora
            //Assim como eu crio uma classe que é um tipo, um delegate tbm é um tipo. Então eu criei "Operação" e posso criar variáveis e constantes do
            //tipo delegate. Uma vez que vc crie uma variável que é do tipo delegate, espera se que seja atribuída uma função que respeite a assinatura.
            //E qual a assinatura do método? É quais são os tipos de parametros recebidos, no caso double, double e qual o tipo de retorno, que tbm é um double


            // Definição de uma variável do tipo delegate Operacao utilizando uma expressão lambda para realizar uma operação de soma e etc
            Operacao sum = (x, y) => x + y;
            Operacao Subtracao = (x, y) => x - y;
            Operacao Divisao = (x, y) => x / y;
            Operacao multiplicacao = (x, y) => x / y;

            //mostrando na tela
            Console.WriteLine(sum(4, 4));
            Console.WriteLine(Subtracao(10, 3));
            Console.WriteLine(Divisao(5, 5));
            Console.WriteLine(Divisao(145, 5));


        }
    }
}
