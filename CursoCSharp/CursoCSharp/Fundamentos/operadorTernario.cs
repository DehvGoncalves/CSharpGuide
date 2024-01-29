using System;


namespace CursoCSharp.Fundamentos
{
    internal class operadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;

            //ternario, de 3. Parte 1, é a primeira expressão nota >= 7.0, parte 2  "Aprovado"  é o segundo operando, e parte três é o segundo operando "Reprovado"
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);           

            //ternario, de 3. Parte 1, é a primeira expressão nota >= 7.0, parte 2  "Aprovado"  é o segundo operando, e parte três é o segundo operando "Reprovado"
            var nota2 = 6.0;
            bool bomComportamento = true;
            String resultado2 = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado"; //precisa tirar nota >7 e ter um bom comportamento
            Console.WriteLine($"Resultado, item da variável resultado2{resultado2}");
        }
    }
}

