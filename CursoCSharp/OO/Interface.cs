using CursoCSharp.OO;
using System;
using System.Collections.Generic;

namespace CursoCSharp.OO {

    interface Teste {
        bool Bla(string a); //uma vez que você define um método desse dentro de uma interface, e vc faz com que uma classe implemente a interface
        //por exemplo eu posso fazer com que a classe Soma implemente a interface, uma vez que vc definiu uma inteface que não tem corpo, implementação, vc é obrigado,
        //dentro da classe que implementa a inteface, se a classe for concreta vc é obrigado a implementar todos os métodos que estão definidos em 
        //todas as interfaces. Uma classe pode implementar multiplas interfaces, mas só pode herdar de uma única classe
        //Interface é uma esrutura em que todos os metodos são públicos e abstratos ou seja, sempre que vc for colocar um método dentro de uma interface, esse método
        //não pode ter corpo(implementação). E uma classe que decide se é aderente a uma interface, obrigatoriamente precisa implementar os métodos definidos na interface
        //Classe pode implementar multiplas interfaces, e uma classe só pode herdar de uma classe
        //uma interface tbm pode herdar de outra interface, nesse caso vc terá que implementar os métodos nas classes que estao herdando as interfaces pai e subinterface
    }
    interface OperacaoBinaria {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria, Teste {//não pode diminuir a visibilidade definida na interface. Aqui eu tenho uma classe que implementa duas interfaces
        public int Operacao(int a, int b) {
            return a + b;
        }
        public bool Bla(string aaa) {//Herdando da interface Bla
            return true;
        }
    }
    class Subtrair : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return (a * b);
        }
    }
    class Divisao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a / b;
        }
    }
    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {//criando uma lista com as operações do tipo OperaçõesBinároas
            new Soma(), //instanciando o new Soma, divisão e etc, vou ter as 4 classes que implementam essa interface aqui dentro
            new Divisao(),
            new Multiplicacao(),
            new Divisao()
        };
        public string ExecutarOperacoes(int a, int b) {//Método que vai executar todas as operações em cima dos parâmetros int a e int b
            string resultado = "";

            foreach (var op in operacoes) {
                //Eu não estou fazendo uma soma e sim uma concatenação acrescentando novas 
                //usando a operação op.GetType().Name ele vai retornar o nome da classe que estou usando, e vou mostrar o resultado em = op.Operacao()
                //O op é exatamente cada um dos elementos da lista que estou percorrendo ner foreach  ai eu chamo o op.Operacao pq cada um desses elementos tem um método chamado operação
                //E obviamente, aqui dentro eu preciso passar os valores de A e B pra que ele possa fazer a operação
                resultado += $"Usando a classe: {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }
    public class Interface {
        public static void Executar() {
            Console.WriteLine("Teste");
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);

            Console.WriteLine(resultado);

            //Aqui ele já vai fazer todas as operações pois todas as classes que estão herdando de interface tem esse método
        }//Passando os valores 20, 5 ele vai percorrer cada item da lista "operacoes" e vai imprimir por exemplo: Usando a classe Soma, e vai chamar a função operação de soma
        //porque cada uma dessas operações implementa a interface que tem essa função. Implementa a interface que tem essa função e passa os valores pra soma, multiplicação e etc...
    }
 
}
