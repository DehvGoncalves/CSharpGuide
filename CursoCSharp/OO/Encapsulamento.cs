using System;
using System.Collections.Generic;
using Encapsulamento; //Importando os metodos e atributos do namespace Encapsulamento que eu criei como um arquivos de classes

namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("*************************************************");
            Console.WriteLine("[FilhoNaoReconhecido] *-* tem acesso aos atributos:");

            Console.WriteLine(InfoPublica);// public
            Console.WriteLine(CorDoOlho);  // herança
            //Console.WriteLine(NumeroCelular);  // Mesmo Projeto (assenbly)
            //Console.WriteLine(SegredoFamilia); // mesma class ou herança no mesmo projeto(a partir da versão 7.2) nesse caso é herança em namespace diferentes
            Console.WriteLine(JeitoDeFalar); // herança ou no mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop); //private é o padrão
        }
    }
    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {

            Console.WriteLine("*************************************************");
            Console.WriteLine("[Amigo Distante] *-* tem acesso aos atributos:");

            Console.WriteLine(amiga.InfoPublica);// public
            //Console.WriteLine(amiga.CorDoOlho);  // herança
            //Console.WriteLine(amiga.NumeroCelular);  // Mesmo Projeto (assenbly)
            //Console.WriteLine(amiga.SegredoFamilia); // mesma class ou herança no mesmo projeto(a partir da versão 7.2) nesse caso é herança em namespace diferentes
            //Console.WriteLine(amiga.JeitoDeFalar); // herança ou no mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop); //private é o padrão
        }
    }
    public class Encapsulamento {
        public static void Executar() {

            //Assim
            SubCelebridade sub = new SubCelebridade ();
            sub.MeusAcessos();

            //ou
            new SubCelebridade().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

            new FilhoNaoReconhecido() .MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
