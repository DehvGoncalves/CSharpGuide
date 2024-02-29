using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    internal class ColecoesArrayList {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                3,
                true
            };
             
            arrayList.Add(3.45);

            Console.WriteLine("Usando o foreach");
            foreach (var indic in arrayList) {
                Console.WriteLine($" Para o indice {indic}");
            }

            Console.WriteLine("**************************************");
            Console.WriteLine("Usando o for");
            for (int i = 0; i < arrayList.Count; i++) {
                Console.WriteLine($" O indice {i} é {arrayList[i]}");
            }

            Console.WriteLine("**************************************");
            Console.WriteLine("Tipos de dados foreach e GetType");
            foreach (var item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}