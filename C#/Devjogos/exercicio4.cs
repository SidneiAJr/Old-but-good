
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int hora = 20;
        
        
        Console.WriteLine ("================Bem vindo==============");
       if(hora==6){
       Console.WriteLine ("Bom dia!"); 
       }else if(hora<12){
        Console.WriteLine ("Boa tarde!");
       }else{
        Console.WriteLine ("Boa Noite!");
       }

    

        Console.WriteLine ("================Obrigado Por Usar!==============");
        
    }
}

