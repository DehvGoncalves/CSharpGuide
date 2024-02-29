using System;
using System.Collections;
using System.Collections.Generic;

class Program {

    static void Executar() {
        // Array
        int[] nomeArray = new int[3]; // Cria um array com tamanho fixo de 3 elementos
        nomeArray[0] = 12;
        nomeArray[1] = 45;
        nomeArray[2] = 23;
        Console.WriteLine("Array:");
        foreach (int item in nomeArray) {
            Console.WriteLine(item);
        }

        // Adicionando um item no Array:
        /*Arrays têm tamanho fixo, então não podemos adicionar um novo elemento diretamente como em List ou ArrayList No entanto, podemos redimensionar o array e copiar os elementos existentes */
        Array.Resize(ref nomeArray, nomeArray.Length + 1); // Redimensiona o array para incluir um novo elemento
        nomeArray[3] = 4; // Adiciona o novo elemento no índice 3
        Console.WriteLine("\nAdicionado 4 no Array:");
        foreach (int item in nomeArray) {
            Console.WriteLine(item);
        }

        // Removendo um item no Array
        /*Em um array, não podemos remover um item diretamente No entanto, podemos criar um novo array sem o elemento que queremos remover*/
        int[] newArray = new int[nomeArray.Length - 1];
        Array.Copy(nomeArray, 0, newArray, 0, 2); // Copia os elementos do array original para o novo array, excluindo o elemento no índice 2
        Console.WriteLine("\nRemovido 3 do Array:");
        foreach (int item in newArray) {
            Console.WriteLine(item);
        }

        // Obtendo o tipo de dados do item no Array
        Type type = nomeArray[0].GetType();
        Console.WriteLine($"\nTipo de dados do primeiro item no Array: {type}");

        Console.WriteLine("********************************************************* FIM *************************************************************************************");

        // List
        List<int> nomeList = new List<int>(); // Cria uma lista dinâmica, lmebrando que é obrigatório importar o Generics
        nomeList.Add(31);
        nomeList.Add(23);
        nomeList.Add(3);
        Console.WriteLine("\nList:");
        foreach (int item in nomeList) {
            Console.WriteLine(item);
        }

        // Adicionando um item na List
        nomeList.Add(87);
        Console.WriteLine("\nAdicionado 4 na List:");
        foreach (int item in nomeList) {
            Console.WriteLine(item);
        }

        // Removendo um item na List
        nomeList.Remove(3);
        Console.WriteLine("\nRemovido 3 da List:");
        foreach (int item in nomeList) {
            Console.WriteLine(item);
        }

        // Obtendo o tipo de dados do item na List
        Type typeList = nomeList[0].GetType();
        Console.WriteLine($"\nTipo de dados do primeiro item na List: {typeList}");

        Console.WriteLine("********************************************************* FIM *************************************************************************************");

        // ArrayList
        ArrayList arrayList = new ArrayList(); // Cria uma coleção dinâmica de objetos
        arrayList.Add(1);
        arrayList.Add("dois");
        arrayList.Add(true);
        Console.WriteLine("\nArrayList:");
        foreach (object item in arrayList) {
            Console.WriteLine(item);
        }

        // Adicionando um item no ArrayList
        arrayList.Add(4.5);
        Console.WriteLine("\nAdicionado 4.5 no ArrayList:");
        foreach (object item in arrayList) {
            Console.WriteLine(item);
        }

        // Removendo um item no ArrayList
        arrayList.Remove(1);
        Console.WriteLine("\nRemovido 1 do ArrayList:");
        foreach (object item in arrayList) {
            Console.WriteLine(item);
        }

        // Obtendo o tipo de dados do item no ArrayList
        Type typeArrayList = arrayList[0].GetType();
        Console.WriteLine($"\nTipo de dados do primeiro item no ArrayList: {typeArrayList}");
    }
}
