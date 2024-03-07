using System;


namespace CursoCSharp.MetodosEFuncoes {
    public class DelegateFuncAnonima {

        delegate string StringOperacao(string s);//esse delegate vai retornar uma String e ele vai receber uma string como parâmetreo
        public static void Executar() {

            //Criando a variável inveter, do tipo StringOperacao e vou atribuir diretamente uma função anônima, então recebe delegate
            //vou passar os parametrso que no caso são os dados que eu recebo (string s) e nas chaves é uma função normal. Daqui (string s) pra frente é uma função normal, a unica coisa que
            //não defini foi o tipo de retorn, mas ele já está definido pelo StringOperacao. Então após o delegate, a partir de (string s) em diante, eu tenho uma função anônima com
            //seus parâmetros e o corpo da função, chamando o return no momento certo.

            /*Neste trecho de código, está sendo criado um delegate anônimo chamado inverter que recebe uma string como parâmetro e retorna outra string. O delegate está sendo definido usando a sintaxe delegate (string s) { ... }, onde a parte entre chaves { ... } representa o corpo do método.
            Dentro do corpo do delegate, a string s é convertida em um array de caracteres usando o método ToCharArray(). 
            Em seguida, o método Reverse da classe Array é usado para inverter a ordem dos elementos no array de caracteres. 
            Por fim, é criada uma nova string a partir do array de caracteres invertido usando o construtor new string(charArray)
            e esta string invertida é retornada pelo delegate. Em resumo, este delegate inverter é capaz de inverter uma string que 
            é passada como argumento para ele.*/
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);

            };
        }
    }
}
