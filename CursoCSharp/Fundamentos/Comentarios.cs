using System;

public class Comentarios
{
    public static void ExemploComentarioSimples()
    {
        // Comentário de uma linha: Este é um exemplo simples.
        Console.WriteLine("1) Para COMENTÁRIO DE UMA LINHA, basta usar // antes do texto, como mostrado abaixo:");
        Console.WriteLine("EXEMPLO: // Isto é um comentário de uma linha");
    }

    public static void ExemploComentarioMultilinha()
    {
        Console.WriteLine("2) Comentário MULTI LINHAS: ");
        Console.WriteLine("EXEMPLO:/*");
        Console.WriteLine("          * Comentário multilinha:");
        Console.WriteLine("          * Este é um exemplo de comentário que se estende por várias linhas.");
        Console.WriteLine("          * Útil para explicar partes maiores de código.");
        Console.WriteLine("          */");
        
    }
    public static void DicasDeComentariis()
    {
        Console.WriteLine("1. Evite comentários desnecessários:");
        Console.WriteLine("   Cuidado com comentários que não agregam informações úteis ao código.");
        Console.WriteLine("   Mantenha seu código claro, utilize bons nomes e garanta fácil leitura.");

        Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade.

        Console.WriteLine("2. Comente durante o aprendizado:");
        Console.WriteLine("   Durante o processo de aprendizado, é válido comentar o código, mesmo que pareça óbvio.");
        Console.WriteLine("   Isso auxilia na consolidação de conhecimentos e facilita a revisão do código.");

        Console.WriteLine(); // Adiciona uma última linha em branco.
    }
    public static void Executar()//Metodo chamado no Program.cs
    {
        Console.WriteLine("Em programação, usamos comentários para explicar o código aos programadores.");
        Console.WriteLine("Existem dois tipos principais de comentários: de [uma linha] e [multilinhas].");
        Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade.
        ExemploComentarioSimples();
        Console.WriteLine();
        Console.WriteLine("****************************************************");
        Console.WriteLine();
        ExemploComentarioMultilinha();
        Console.WriteLine();
        DicasDeComentariis();
        Console.WriteLine("****************************************************");

    }


}
