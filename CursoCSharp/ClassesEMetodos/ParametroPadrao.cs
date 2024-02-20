using System;


namespace CursoCSharp.ClassesEMetodos {
    public class ParametroPadrao {

        public static int Somar(int a = 1, int b = 1) {//Metodo somar com 2 parametros , a e b.
                                                       //Ao chamar o método caso nenhum valor seja passado, o valor padrão será que foi setado na assinatura do método.
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 23)); //Passando novos valores aos parametros, nesse caso o valor padrão será descartado. 
            Console.WriteLine(Somar(50)); //Passando apenas um valor, o segundo valor será o padrão.
            Console.WriteLine(Somar()); //Não passando nenhum valor, os dois valores serão padrão.
            Console.WriteLine(Somar(b:17)); //Passando apenas o segundo valor, o primeiro valor será o padrão.

        }
        /*Basicamente o parametro com valor padrão é um parametro que já tem um valor pré definido, caso nenhum valor seja passado, o valor padrão será utilizado.*/

    }
}
