using System;

namespace Teste
{
    class Program
    {
        static void Main(string[]args)
        {
            double valini;
            double credi;
            double crediario;
            double deb;
            double rest;
            int parcelas;
            
            Console.WriteLine("Por favor Insira o valor Inicial:");
            valini=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor Insira o Numero de parcelas:");
            parcelas=Convert.ToInt16(Console.ReadLine());
            
            credi=valini*8;
            crediario=valini*12;
            deb=valini;
            rest=(crediario*0.05)*12/parcelas;
            
            Console.WriteLine("O Valor Inicial será R${0}",valini);
            Console.WriteLine("O Valor no cartao de credito em parcelas e:R${0}",credi);
            Console.WriteLine("O Valor no Crediario sera:R${0}",crediario);
            Console.WriteLine("O Valor Original sem desconto:R${0}",valini);
            Console.WriteLine("O Juros sera:R${0}",rest);
            
            

        }
    }
}
