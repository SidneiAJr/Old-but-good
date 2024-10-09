
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int hora = 20;
        
        
        Console.WriteLine ("================Bem vindo==============");
       if(hora<6){
       Console.WriteLine ("Manhã"); 
       }else if(hora<12){
        Console.WriteLine ("Tarde");
       }else if(hora<19){
        Console.WriteLine ("Noite");
       }else{
        Console.WriteLine ("Madrugada");   
       }

    

        Console.WriteLine ("==========Obrigado Por Usar!==========");
        
    }
}

