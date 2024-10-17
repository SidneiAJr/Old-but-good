using System;
namespace Teste
{
    class Teste
    {
        public void calculo(string Nome = "Albertao",double altura = 1.72, int idade = 26){
        Console.WriteLine ($"Seu Nome e {Nome} e voce tem  {altura} e tenho de idade {idade}");
        }
        static void Main(string[]args){
            Teste meuObj = new Teste();
            meuObj.calculo("Albertao",1.72,26);
        }

    }
}
