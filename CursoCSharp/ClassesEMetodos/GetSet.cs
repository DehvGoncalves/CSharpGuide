using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)//construtor que recebe os 3 parametros
        {
            Marca = marca; //Para setar o parametro que recebi no construtor setar o atributo da classe
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto()
        {

        }
        public string GetMarca() //Metodo para retornar a marca
        {
            return Marca; //retorna o valor salvo no atributo
        }
        public void SetMarca(string marca) //Metodo para setar a marca
        {
            Marca = marca; //Significa que o atributo Marca vai receber o valor que eu passar
        }
        public string GetModelo() //Metodo para retornar o modelo
        {
            return Modelo;
        }
        public void SetModelo(string modelo) //Metodo para setar o modelo
        {
            Modelo = modelo;
        }
        public int GetCilindrada() //Metodo para retornar a cilindrada
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada) //Metodo para setar a cilindrada
        {
            Cilindrada = cilindrada;
        }
        public static void InserirMoto(String marca, String modelo, int cilindrada)//Modelo incluido para testar o void. Onde consigo chamar o metodo sem instanciar a classe
        {
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto(marca: "Kawasaki", modelo:"Ninja ZX-6R", cilindrada: -636);//Construindo o objeto setando os valores pelo construtor
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
            Console.WriteLine("********************");

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);
            Console.WriteLine(moto2.GetMarca() + ", "+ moto2.GetModelo() + ", " + moto2.GetCilindrada()+ ".");
        }
    }
}
