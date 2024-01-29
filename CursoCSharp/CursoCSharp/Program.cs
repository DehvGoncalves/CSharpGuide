using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.diarioDeUmDev;
using CursoCSharp.diarioDeUmDev;
using CursoCSharp.ClassesEMetodo;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", comentarios.executar},
                {"Variáveis e Constantes - Fundamentos", variaveisEConstantes.executar},
                {"Iferência - Fundamentos", inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Formatando Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", operadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", operadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", operadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", operadorTernario.Executar},
                //Estruturas de Controle
                {"Estrutura  de condição  If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura  de condição If Else - Estruturas de Controle", esruturaIfElse.Executar},
                {"Estrutura de condição If Else, If Else - Estruturas de Controle", estruturaIfElseIf.Executar},
                {"Estrutura de comparação  Switch - Estrutura Switch", estruturaSwitch.Executar},
                {"Estrutura de Repetição - WHILE", Estruturawhile.Executar},
                {"Estrutura de Repetição - DO WHILE", estruturaDoWihile.Executar},
                {"Estrutura de Repetição - FOR", estruturaFor.Executar},
                {"Estrutura de Repetição - FOREACH", estuturaForEach.Executar},
                {"Usando o BREAK", estruturaBreak.Executar},
                {"Usando o Continue", usandoContinue.Executar},
                {"Oque você aprendeu hoje? ", aprendendo.executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos ", Membros.Executar},
                {"Contrutores - Classes e Métodos ", Construtores.Executar},
                {"Métodos com retorno (1) - Classes e Métodos ", MetodosComRetorno.Executar},

            }); 

            central.SelecionarEExecutar();
        }
    }
}