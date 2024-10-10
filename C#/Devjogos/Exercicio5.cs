using System;
namespace Teste
{
    class Program
    {
        static void Main()
        {
        int num=10;
        
        while(num>0){
        if(num==0){
            Console.Write("Boom");
        }else if(num %2 ==0){
           Console.Write("TIC");  
        }else{
          Console.Write("TAC");    
        }
       num--;
       
        }
        
        
        }
        
    }
}
