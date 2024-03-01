using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace CursoCSharp.Colecoes {
    public class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();//Obrigatoriamente é chave e valor então tenho dois valores dentro da notação do Generics, tem que imporrar Generic, a chave vai ser o inteiro e o valor vai ser uma string. Lmebrando que um dicionando aceita recetição no valor mas não aceita na chave, é chave primária

            filmes.Add(2004, "Gladiador");
            filmes.Add(2022, "Homem-Aranha");
            filmes.Add(2023, "O Grande Truque");
            filmes.Add(2024, "O código limpo");

            if (filmes.ContainsKey(2004)) {
                //verificar se uma determinada chave está contida
                Console.WriteLine("2024: " + filmes[2004]); //usando a chave que é 2004, pra pegar o valor do filme, que no caso é o nome
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2024));//Melhor usar esse aqui
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2020));
            }
            //verificar se um determinado valor existe, retorna true e false
            Console.WriteLine(filmes.ContainsValue("Amenesia"));

            //Remover filme da lista
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2022, out string filme2022); //forma de passar valor por referência, vai pegar o valor e jogar na variável filme2016
            Console.WriteLine(filme2022);

            //formas de percorrer chave, pra cada uma chave ele vai mostrar
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }
            //percorrendo valores
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            //percorrendo chave e valor ao mesmo tempo
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($" {filme.Value} é de {filme.Key}");
            }
            //outra forma valor e chave, forma mais fácil e simples
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
