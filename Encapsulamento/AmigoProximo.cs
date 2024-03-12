using System;
using System.Collections.Generic;


namespace Encapsulamento {
     class AmigoProximo {
        //não tem herança mas como está dentro do mesmo projeto, ele tem alguns beneficios de acessar alguns atributos

        //como não tem herança, vou acessar os atributos a partir de composição. Usando uma variável que no caso é amiga (instanciando objeto amiga)
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo consegue acessar alguns atributos de SubCelebridade");
            Console.WriteLine("São eles");

            Console.WriteLine(amiga.InfoPublica);// public
            //Console.WriteLine(amiga.CorDoOlho);  // herança
            Console.WriteLine(amiga.NumeroCelular);  // Mesmo Projeto (assenbly)
            //Console.WriteLine(amiga.SegredoFamilia); // mesma class ou herança no mesmo projeto(a partir da versão 7.2)
            Console.WriteLine(amiga.JeitoDeFalar); // herança ou no mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop); //private é o padrão
        }
    }
}
