using System;


namespace CursoCSharp.Colecoes {
    public class Array {
        public static void Executar() {
            /*O unico identificador alunos vai referenciar 5 strings. O Array é uma estrutura homogenea e todos os elementos devem ser do mesmo tipo.
            O Array é uma estrutura de tamanho fixo, ou seja, não é possivel adicionar ou remover elementos. Oque você pode fazer é atribuir um novo array com o tamanho desejado.
            É uma estrutura indexada, começando no indice 0*/

            //EXEMPLO ATRIBUINDO VALOR A CADA ELEMENTO DO ARRAY
            string[] alunos = new string[5];
            alunos[0] = "João";
            alunos[1] = "Ana";
            alunos[2] = "Bia";
            alunos[3] = "Carlos";
            alunos[4] = "Daniel";

            //Quero percorrer o array do primeiro ao ultimo elemento, nesse exmmplo vamos usar o foraech
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);

            }
            Console.WriteLine("**************************************************************************************************************");

            //EXEMPLO ATRIBUIR VALOR PASSANDO DIRETO NO ARRAY
            double somatorio = 0;
            double[] notas = { 9.7, 4.3, 5.2, 8.8, 7.7 };

            //EXEMPLO PERCORRER COM FOR
            for (int i = 0; i < notas.Length; i++) {
                somatorio += notas[i];//A variável somatorio vai receber o valor dela mais o valor passado na variável notas[i]. Assim sendo, terei a soma de todos os elementos do array.
            }

            //Estou usando o foreach, criando a variável nota para percorrer todos os elementos contidos no array notas. A cada iteração,
            //o valor da variável será o valor do elemento atual do array.
            
            //EXEMPLO PERCORRER COM FOREACH
            foreach (var nota in notas) {
                somatorio += nota;//A variável somatorio vai receber o valor dela mais o valor passado na variável nota. Assim sendo, terei a soma de todos os elementos do array.
            }
            double media = somatorio / notas.Length;//A variável media vai receber o valor da variável somatorio dividido pelo tamanho do array notas.
            Console.WriteLine($"A média de notas é {media}");

            Console.WriteLine("**************************************************************************************************************");

            //EXEMPLO ATRIBUIR VALOR PASSANDO DIRETO NO ARRAY
            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);//A variável palavra vai receber uma nova string, que será criada a partir do array letras. Ao imprimir a variável palavra, teremos a palavra Array.
            Console.WriteLine(palavra);

            Console.WriteLine("****************************************");


            //EXEMPLO PERCORRER COM FOR
            string[] nomes = new string[] { "Debora", "Poliana", "Maria" };

            for (int i = 0; i < nomes.Length; i++) {
                Console.WriteLine(nomes[i]);
            }


            //EXEMPLO PERCORRER COM FOREACH
            int[] notass = new int[3];
            notas[0] = 9;
            notas[1] = 10;
            notas[2] = 8;

            double somaa=0;
            foreach (var i in notas) {
                somaa = +i;
            }
            double mediaa = somaa / notas.Length;
            Console.WriteLine(mediaa);

            Console.WriteLine($" O Array tem o tamanho: {alunos.Length}");


        }


    }

}

