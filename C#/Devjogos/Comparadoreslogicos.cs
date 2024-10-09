using System;

public class OperadoresLogicos
{
    public static void Main(string[] args)
    {
       
        bool temCarteira = true;
        int idade = 26;
        bool maiorIdade= idade >= 18;

        Console.WriteLine("Para poder dirigir voce precisa ter 18 anos ou mais",maiorIdade);
        Console.WriteLine("Voce tem carteira",temCarteira);
        Console.WriteLine(temCarteira==true&& maiorIdade == true);
        if(idade>18){
            Console.WriteLine("Voce e maior de idade!");
        }else{
           Console.WriteLine("Voce e menor de idade!"); 
        }

        
      
      

    }
}
