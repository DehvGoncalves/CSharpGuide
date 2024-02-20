using System;


namespace CursoCSharp.ClassesEMetodos {
    public class Dependente {
        public string Nome;//A classe string é uma classe, e a atribuição é por referência e não por valor
        public int Idade; //A classe int é struct, e a atribuição é por valor e não por referência
    }
    public class ValorVsReferencia {
        public static void Executar() {

            Console.WriteLine("INT ÉTIPO STRUCT - A ATRIBUIÇÃO É POR VALOR E NÃO POR REFERÊNCIA");
            int numero = 3;//tipo int é struct, e a atribuição é por valor e não por referência
            int copiaDoNumero = numero;
            Console.WriteLine($"Atribuição inicial: numero: {numero}, copiaDoNumero:{copiaDoNumero}");

            numero++; //numero recebe numero + 1
            Console.WriteLine($" numero será 4, que é  3 atribuído primeiro + 1: {numero} já o copiaDoNumero vai valer 3, que é a cópia inicial de numero: {copiaDoNumero}");

            Console.WriteLine("******************************************************************");
            Console.WriteLine("STRING ÉTIPO CLASSE - A ATRIBUIÇÃO É POR REFERÊNCIA E NÃO POR VALOR");
           
            Dependente dep = new Dependente {
                Nome = "Beto",
            };
            Dependente copiaDependente = dep;
            dep.Nome = "Renato";

            Console.WriteLine($"Atribuição inicial: dep.Nome: {dep.Nome}, copiaDependente.Nome:{copiaDependente.Nome}");

        }


    }
}
