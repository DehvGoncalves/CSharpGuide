using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    public class ColecoesArrayList {
        public static void Executar() {

            //Criando ArrayList
            var nomeArrayList = new System.Collections.ArrayList() {
                "Debora",
                4,
                false
            };


            //Imprimindo os dados da ArrayLis
            Console.WriteLine("\nomeArrayList:");
            foreach (object item in nomeArrayList) {
                Console.WriteLine(item);
            }

            // Adicionando um item no ArrayList
            nomeArrayList.Add(4.5);
            Console.WriteLine("\nAdicionado 4.5 no ArrayList:");
            foreach (object item in nomeArrayList) {
                Console.WriteLine(item);
            }

            // Removendo um item no ArrayList
            nomeArrayList.Remove(1);
            Console.WriteLine("\nRemovido 1 do ArrayList:");
            foreach (object item in nomeArrayList) {
                Console.WriteLine(item);
            }

            // Obtendo o tipo de dados do item no ArrayList
            //Exemplo modo unitário
            Type type2 = nomeArrayList[0].GetType();
            Console.WriteLine($"\nTipo de dados do primeiro item no ArrayList: {type2}");

            //Exemplo de todos os dados
            Console.WriteLine("**************************************");
            Console.WriteLine("Tipos de dados foreach e GetType");
            foreach (var item in nomeArrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}