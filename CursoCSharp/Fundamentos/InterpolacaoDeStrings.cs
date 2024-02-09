using System;

namespace CursoCSharp.Fundamentos
{
    internal class InterpolacaoDeStrings
    {
        // Método que exemplifica a Interpolação de Strings (Recomendado):
        public static void ConcatenacaoInterpolacao()
        {
            string nome = "Leonardo", idade = "25", salario = "1000.00";
            Console.WriteLine($"Interpolação de Strings: Nome: {nome}, Idade: {idade}, Salário: {salario}");
        }

        // Método que exemplifica a Concatenação Tradicional:
        public static void ConcatenacaoTradicional()
        {
            string nome = "Leonardo", idade = "25", salario = "1000.00";
            Console.WriteLine("Concatenação Tradicional: " + nome + ", Idade: " + idade + ", Salário: " + salario);
        }

        // Método que exemplifica a Concatenação usando String.Format:
        public static void ConcatenacaoStringFormat()
        {
            string nome = "Leonardo", idade = "25", salario = "1000.00";
            Console.WriteLine("String.Format: " + String.Format("Nome: {0}, Idade: {1}, Salário: {2}", nome, idade, salario));
        }

        // Método que exemplifica a Concatenação usando String.Concat:
        public static void ConcatenacaoStringConcat()
        {
            string nome = "Leonardo", idade = "25", salario = "1000.00";
            Console.WriteLine("String.Concat: " + string.Concat("Nome: ", nome, ", Idade: ", idade, ", Salário: ", salario));
        }

        // Método que exemplifica a Concatenação usando String.Join (faltava explicação):
        public static void ConcatenacaoStringJoin()
        {
            string nome = "Leonardo", idade = "25", salario = "1000.00";
            Console.WriteLine("String.Join: " + string.Join(", ", "Nome: ", nome, "Idade: ", idade, "Salário: ", salario));
        }

        // Método principal que será chamado na classe Program.cs:
        public static void Executar()
        {
            /* 
             * A interpolação de strings é uma maneira mais simples de concatenar strings e variáveis.
             * Para usar, basta colocar o símbolo '$' antes das aspas duplas e dentro da string, adicionar o nome da variável entre chaves.
             * A interpolação de strings é mais performática do que a concatenação tradicional.
             */
            // Abaixo, temos alguns exemplos de concatenação de strings e variáveis:
            ConcatenacaoInterpolacao();
            ConcatenacaoTradicional();
            ConcatenacaoStringConcat();
            ConcatenacaoStringConcat();
            ConcatenacaoStringJoin();
        }
    }
}
