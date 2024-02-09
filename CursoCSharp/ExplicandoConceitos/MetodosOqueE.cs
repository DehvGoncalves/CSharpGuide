using System;

public class MetodosExemplos
{
    /*Metodos são conjuntos de instruções dentro de uma classe que realizam tarefas específicas.
     * Eles sao Úteis para:
     * Reutilização do código: Permitem escrever uma vez e usar várias vezes.
     * Organização: Facilitam a divisão do código em partes menores e mais gerenciáveis.
     * Existem dois tipos principais de métodos:
     *      1. Métodos com Retorno (return)
     *      2. Métodos sem Retorno (void)
     * Abaixo os 4 tipos de métodos possivels
     */


    //*********** RETURN, METODOS COM RETORNO ***********
    public int Somar(int a, int b) //exemplo de método com entrada de dados e retorno
    {
        return a + b;
    }

    public string Saudacao() //exemplo de método sem entrada de dados e com retorno
    {
        return "Olá, tudo bem?";
    }

    //*********** VOID, METODOS SEM RETORNO ***********
    public void Imprimir(string texto) //exemplo de método com entrada de dados e sem retorno
    {
        Console.WriteLine(texto);
    }
    void Mensagem() //exemplo de método sem entrada de dados e sem retorno
    {
        Console.WriteLine("Método sem retorno");
    }
}