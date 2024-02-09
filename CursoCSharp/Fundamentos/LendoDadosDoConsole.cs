using System;
using System.Security.Cryptography.X509Certificates;

public class LendoDadosDoConsole
{
    public static void Executar()
    {
        /*
         * Para ler dados do console, utilizamos o método ReadLine() da classe Console.
         * Este método retorna uma string, portanto, se quisermos ler um número inteiro,
         * devemos converter o valor de string para inteiro.
         */
        Console.WriteLine("Informe seu nome: ");
        String nome = Console.ReadLine(); // Lê uma linha de texto do console

        Console.WriteLine("Informe sua idade, ela será convertida em inteiro, caso digite algo não númerico o sistema retornará um erro: ");
        int idade = int.Parse(Console.ReadLine()); // Lê uma linha de texto do console, e converte para inteiro

    }
}