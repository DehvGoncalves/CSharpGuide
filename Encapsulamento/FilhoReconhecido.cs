using System;
using System.Collections.Generic;

namespace Encapsulamento {

    //como existe herança, não preciso criar uma instancia de SubCelebridade pra acessar porque eu vou receber esses atributos por herança
    class FilhoReconhecido : SubCelebridade { // herança
        public new void MeusAcessos() {
            Console.WriteLine("FilhoReconhecido consegue acessar alguns atributos de SubCelebridade");
            Console.WriteLine("São eles");

            Console.WriteLine(InfoPublica);// public
            Console.WriteLine(CorDoOlho);  // herança
            Console.WriteLine(NumeroCelular);  // Mesmo Projeto (assenbly)
            Console.WriteLine(SegredoFamilia); // mesma class ou herança no mesmo projeto(a partir da versão 7.2)
            Console.WriteLine(JeitoDeFalar); // herança ou no mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop); //private é o padrão
        }
    }
}
