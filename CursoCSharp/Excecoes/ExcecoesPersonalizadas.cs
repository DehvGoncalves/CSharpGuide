using System;
using System.Collections.Generic;
using System.Text;

//Vou gerar um número aleatório entre -30 e 30, buscando apenas positivos pares, caso contrário, lançarei uma exceção.
namespace CursoCSharp.Excecoes {

    //geralmente vc coloca Exception no nome quando se trata de exceções, pra que de fato a exceção seja uma exceção, a uma relação é 1. NEGATIVOEXCEPTION É UMA EXCEÇÃO.
    //Quando tenho uma relação É1, via de regra estou falando de herança, como Exception já dentro de System então não preciso importar namespace pq já é nativo sei la
    //Dentro de Exception já existem varios construtores que eu posso querer definir dentro de NegativoException. Posso ter o padrão e outros


    //Quando o número for negativo, eu vou gerar uma exceção
    public class NegativoException : Exception {//criei uma nova classe que herda de Exception e abaixo eu só fiz definir os construtores pra que eu possa mais ou menor definir os contstrutores que existem em exception
        public NegativoException() { } // Metodo construtor

        public NegativoException(string message) : base(message) { } //Construtor que vai receber uma msg string e vou chamar o construtor base tbm  chamando a msg

        public NegativoException(string message, Exception inner)
            : base(message, inner) { }// construtor vai receber dois parametros, uma msg e uma exceção interna chamada inner, e vou chamar o construtor base passando a msg e a exceção que foi a causa da exceção

    }

    //Quando o número for ímpar, eu vou gerar uma exceção
    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }

    public class ExcecoesPersonalizadas {
        //Esse método vai gerar um número aleatório entre -30 e 30, e caso seja positivo e par, ele vai retornar o número, caso contrário, ele vai lançar uma exceção
        public static int PositivoPar() {
            Random random = new Random();//criei um objeto random, random é uma classe que gera números aleatórios
            int valor = random.Next(-30, 30);//vai gerar um número aleatório entre -30 e 30

            if (valor < 0) {
                throw new NegativoException("Número negativo...:(");//lançando a exceção, se o valor for negativo
            }
            if (valor % 2 == 1) {
                throw new ImparException("Valor ímpar...:(");//lançando a exceção, se o valor for ímpar
            }

            return valor;

        }
        public static void Executar() {
            //Aqui vamos colocar o console.writeline dentro de um try catch, para que ele possa capturar a exceção que foi lançada, o bloco tryCatch é usado sempre que a chamada do método pode lançar uma exceção
            try {
                Console.WriteLine(ExcecoesPersonalizadas.PositivoPar());
            }
            catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

