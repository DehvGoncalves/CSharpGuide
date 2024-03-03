using System;

namespace CursoCSharp.OO {

    public class Carro {
        /* Atributos do tipo readonly só pode ser atribuído durante a declaração do campo ou dentro do construtor da classe. Uma vez atribuído, o valor não pode ser alterado. 
          o campo VelocidadeMaxima da classe Carro só pode ser atribuído uma vez, seja na declaração ou dentro do construtor da classe. Após isso, seu valor não pode ser modificado
        */
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual; 

        public Carro() { }//construtor padrão p/ permitir herdar, se eu não tiver o contrutor padrão, é sou obrigada a chamar o construtor base na classe filho
        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        /*O nome delta é comumente usado para representar uma mudança incremental em um valor, o que é apropriado para o contexto de alterar a velocidade de um carro.
         * No entanto, se desejar um nome mais descritivo, você poderia usar algo como mudancaVelocidade, variacaoVelocidade ou incrementoVelocidade. 
         * O importante é escolher um nome que seja claro e conciso,
         */
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        public int Acelerar() {//por padrão vou fazer com que cada carro acelere de 5 em 5km por hora, toda vez que esse método for chamado, ele acrescentará 5km por hora
            VelocidadeAtual += 5;//Velocidade atual + 5
            return VelocidadeAtual;
        }
        public int Frear() {
            VelocidadeAtual += -5; // Adicionar -5 à velocidade atual e armazenar o novo valor
            if (VelocidadeAtual < 0) {
                VelocidadeAtual = 0;
            }
            return VelocidadeAtual; //Subtrair 5km por hora quando chamar frear
        }

    }
    class Uno : Carro {
        public Uno() : base(10) {//criei o construtor padrão de Uno, chamando o construtor da classe pai pra informar a velocidade máxima

        }

    }
    public class Ferrari : Carro {
        
    }
    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("FERRARI");
            
            Ferrari ferrari1 = new Ferrari();
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());


        }

    }


}
