function somar(){
    let n1 = Number(prompt("Informe um numero: "))
    let n2 = Number(prompt("Informe um numero: "))
    let n3 = Number(prompt("Informe um numero: "))
    let n4 = Number(prompt("Informe um numero: "))
    let soma = n1+n2+n3+n4
    console.log("Soma:" ,soma)
}
function subtracao(){
    let n1 = Number(prompt("Informe um numero: "))
    let n2 = Number(prompt("Informe um numero: "))
    let n3 = Number(prompt("Informe um numero: "))
    let n4 = Number(prompt("Informe um numero: "))
    let sub = n1-n2-n3-n4
    console.log("Subtracao: ",sub)
}
function div(){
    let n1 = Number(prompt("Informe um numero: "))
    let n2 = Number(prompt("Informe um numero: "))
    let n3 = Number(prompt("Informe um numero: "))
    let n4 = Number(prompt("Informe um numero: "))
    let div = n1/n2/n3/n4
    console.log("Divisão: ",div)
}
function mult(){
    let n1 = Number(prompt("Informe um numero: "))
    let n2 = Number(prompt("Informe um numero: "))
    let n3 = Number(prompt("Informe um numero: "))
    let n4 = Number(prompt("Informe um numero: "))
    let mult = n1*n2*n3*n4
    console.log("Multiplicação: ",mult)
}
function master(){
     op = Number(promp("1- Somar\n -2 - Subtracao \n 3- divisao\n 4- Multiplicao"))
     while(op!=4){
         case(op){
             case 1:
             somar()
             break;
             case 2:
             subtracao()
             break;
             case 3:
             div()
             break;
             case 4:
             mult()
             break;
             default:
             console.log("Opção Invalida!!")
             break;
                
         }
     }
}
master()
