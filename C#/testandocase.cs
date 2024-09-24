using System;
class progcalculotempo(){
    int tempo=0;
    char Escolha=;
    Console.WriteLine("Transportes pelo brasil: ");
    Console.WriteLine("Escola o tipo de transporte:[a]Aviao|[c]carro|[o]Onibus");
    escolha=char.Parse(console.Read());
    switch(){
        case 'a':
        tempo = 50;
        break;
        case 'c':
        tempo= 480;
        break;
        case 'o':
        tempo =600;
        break;
        default:
        tempo=-1;
        break
    }
    if(tempo<0){
     Console.WriteLine("Transporte Não reconhecido");
    }else{
Console.WriteLine("Tempo escolhido:{0} Minutos",tempo);
    }
}
