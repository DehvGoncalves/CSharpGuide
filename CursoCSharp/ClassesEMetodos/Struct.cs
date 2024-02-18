using System;


namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto//interface tem sintaxe parecida com classe, mas em vez de criar funções/metodos que tem o corpo, vc cria apenas assinatura da função e quem tiver aderente a essa interface, signica que a estrutura a struct vai ter que ter o metodo com aquela mesma assinatura inclusive com o mesmo tipo de retorno. A classe tbm, se ela está aderente a interface, obrigatoriamente ela precisa definir essa interface.
    {
        void MoverNaDiagonal(int delta);//mover um ponto, função sem corpo apenas definir o tipo da função, Na interface, o método da interface sempre será publico
    }
    struct Coordenada: Ponto//essa struct deve ser aderente a interface Ponto
    {
        public int X; 
        public int Y;

        public Coordenada(int x, int y)
        {
            this.X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)//construtor 
        {
            X += delta; //Acrescentando valor de delta a X
            Y += delta;//Acrescentando valor de delta a Y
        }
    }
    public class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coornadaInicial = new Coordenada(x:9, y:1);
            coornadaInicial.X = 3;
            coornadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial");
            Console.WriteLine("X = {0} ", coornadaInicial.X);
            Console.WriteLine("Y = {0} ", coornadaInicial.Y);

            var coordenadaFinal = new Coordenada(x:7, y:14);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

        }

    }
}
