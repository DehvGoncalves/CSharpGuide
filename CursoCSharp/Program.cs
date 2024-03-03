using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.ExplicandoConceitos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;


namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args) { //Metodo Main usado para iniciar a aplicação
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"******************ATALHOS******************", Atalhos.Executar},
                {"**************MÉTODOS RÁPIDOS**************", MetodosRapidos.Executar},
                {"PRIMEIRO PROGRAMA - Fundamentos", PrimeiroPrograma.Executar},
                {"COMENTARIOS - Fundamentos", Comentarios.Executar},
                {"VARIÁVEIS e CONSTANTES - Fundamentos", VariaveisEConstantes.Executar},
                {"INFERENCIA - Fundamentos", Inferencia.Executar},
                {"INTERPOLAÇÃO DE STRINGS - Fundamentos", InterpolacaoDeStrings.Executar},
                {"NOTACAO PONTO - Fundamentos", NotacaoPonto.Executar},
                {"LENDO DADOS - Fundamentos", LendoDadosDoConsole.Executar},
                {"CONVERSÕES - Fundamentos", Conversoes.Executar},
                {"OPERADORES ARITMÉTICOS - Fundamentos", Conversoes.Executar},

                //CLASSES E MÉTODOS
                {"CLASSES E METODOS 2 - Classes e Métodos", Data.Executar},
                {"METODOS - Classes e Métodos", Metodos.Executar},
                {"MEMBROS - Classes e Métodos", Membros.Executar},
                {"CONSTRUTORES - Classes e Métodos", Construtores.Executar},
                {"MÉTODOS COM RETORNO - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Com Retorno #02 Encadear varias chamadas this - Classes e Métodos", CalculadoraCadeia.Executar},
                {"MÉTODOS ESTÁTICOS - Classes e Métodos", MetodosEstaticos.Executar},
                {"ATRIBUTOS ESTÁTICOS - Classes e Métodos", AtributosEstaticos.Executar},
                {"Get e Set - Classes e Métodos", GetSet.Executar},
                {"PROPS - Classes e Métodos", Props.Execurar},
                {"READONLY Atributo somente leitura, Constante - Classes e Métodos", Readonly.Executar},
                {"ENUM - Classes e Métodos", ExemploEnum.Executar},
                {"STRUCT - Classes e Métodos", ExemploStruct.Executar},
                {"STRUCT x CLASSES - Classes e Métodos", StructXClasse.Executar},
                {"VALOR Vs REFERENCIA - Classes e Métodos", ValorVsReferencia.Executar},
                {" Reg/Out Parametros por referência - Classes e Métodos", ParametrosPorReferenciaRefOut.Executar},
                {" PARAMETRO COM VALOR PADRÃO - Classes e Métodos", ParametroPadrao.Executar},

                //COLEÇÕES
                {" ARRAY - Coleções", Colecoes.Array.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" LIST - Coleções", ColecoesList.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" LIST - Coleções, Irmãs kkkk", Colecoes.Cliente.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" ArrayList - Coleções", ColecoesArrayList.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" SET - Coleções", ColecoesSet.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" QUEUE, Fila - Coleções", ColecoesQueueFila.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" IGUALDADE, (Equals e GetHashCode) - Coleções", Igualdade.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" Stack, Pilha, (Fila de Pilha) - Coleções", ColecoesStack.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                {" Dictionary - Coleções", ColecoesDictionary.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
                
                //PROGRAMAÇÃO ORIENTADA A OBJETO
                {" HERANÇA - OO", Heranca.Executar},// O nome Array é uma palavra reservada e dará conflito. Com isso para referênciar você deve informar o namespace antes.
            });

            central.SelecionarEExecutar();
        }

    }
}