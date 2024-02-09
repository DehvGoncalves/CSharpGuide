using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)//Na hora de passar instanciar o objeto, Será que o primeiro parâmetro é o dia, o segundo o mês e o terceiro o ano?
        {   //D2 serve para formatar, d2 é para que o número tenha dois dígitos
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Formatar(mes: 7, dia: 31, ano: 2021);//Aqui eu posso passar os parâmetros em qualquer ordem, pois eu estou passando o nome do parâmetro2024
            Formatar(ano: 2024, mes: 2, dia: 07);
            //É simples é só colocar o nome do parâmetro indicando o parametro exato que você quer passar
        }

        public static int Somar(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public static void Executar2()
        {
            Console.WriteLine(Somar(10, 10, 10, 10)); //sem nomear
            Console.WriteLine(Somar(a: 10, b: 10, c: 10, d: 10)); //nomeando
            Console.WriteLine(Somar(d: 10, c: 10, b: 10, a: 10));
            Console.WriteLine(Somar(10, d: 10, b: 10, c: 10));
        }


    }
}
