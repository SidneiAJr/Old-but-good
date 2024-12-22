const menu = prompt("Informa a opção 1 ou 2 ")
switch(menu){
    case '1':
    calc()
    break
    case '2':
    calc2()
    break
    deFault:
    console.log("Opção Invalida")
    break
}
function calc(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial: "))
const juros = Number(prompt("Favor Informar o juros do cupom: "))
const tempo = Number(prompt("Favor Informar o Tempo em Anos "))
const juros2 = juros/100
const calculo = valorIni*(1+juros2)**tempo
console.log("O Valor em R$",calculo)
}
function calc2(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial: "))
const juros = Number(prompt("Favor Informar o juros do cupom: "))
const tempo = Number(prompt("Favor Informar o Tempo em Anos "))
const juros2 = juros/100
const mes = tempo/12
const calculo = valorIni*(1+juros2)**mes
console.log("O Valor em R$",calculo)
}
