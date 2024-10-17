using System;
    class personagem
    {
       //Atributos atributos são variaives  que minha classe usa
       // Constructor e uma função/metodo definido como os objetos
       // Metodos sao função que representam o que objeto dessa classe pode fazer
       public string nome;
       public int forca;
       public double roubovida;
       public int vida;
       public double velataque;

       public void atacar(){
         Console.WriteLine($"{nome}Ataca com {forca} Pontos de forca,e tem {velataque}Velocidade de ataque base, O % de roubo de vida é{roubovida}")
       }
       public void Andar(){
        Console.WriteLine($"{nome}está Andando.")
       }
           
        }
