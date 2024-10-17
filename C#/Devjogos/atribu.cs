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
         Console.WriteLine($"O Personagem {nome} Ataca com {forca}, e tem de velocidade de ataque {velataque} Velocidade de ataque base, seu roubo de vida é {roubovida}");
       }
       public void Andar(){
        Console.WriteLine($"{nome}está Andando.");
       }
       public personagem(string nomepersonagem,int forcaInicial,int VidaInicial, double velataque2,double roubo){
          nome = nomepersonagem;
          forca = forcaInicial;
          vida = VidaInicial;
          velataque = velataque2;
          roubovida = roubo;
       }
}

class inimigo{
    public string nome;
    public int forca;
    public int vida;
    public void atacar(){
         Console.WriteLine($"O Inimigo {nome} Ataca com {forca}");
       }
       public void Andar(){
        Console.WriteLine($"{nome}está Andando.");
       }
       public inimigo(string nomeinimigo, int forcaInicial, int vidaIni){
          nome = nomeinimigo;
          forca = forcaInicial;
          vidaIni= vida;
       }
}


class Jogo
{
            static void Main(string[] arg){
                //Criar um personagem
                personagem personagem1 = new personagem("Queen",20,4,1.25,0.75);
                personagem1.atacar();
                personagem1.Andar();
                inimigo inimigo1 = new inimigo("zumbi",20,400);
                inimigo1.atacar();
                inimigo1.Andar();

                


            }
}    
