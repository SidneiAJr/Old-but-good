const menu = prompt("Informa a opção 1 ou 4:")
switch(menu){
    case '1':
    calc()
    break
    case '2':
    calc2()
    break
    case '3':
    calc3()
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
console.log("O Valor em R$",Math.floor(calculo))
}
function calc2(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial: "))
const juros = Number(prompt("Favor Informar o juros do cupom: "))
const tempo = Number(prompt("Favor Informar o Tempo em Meses "))
const juros2 = juros/100
const mes = tempo/12
const calculo2 = valorIni*(1+juros2)**mes
console.log("O Valor em R$",Math.floor(calculo2))
}
function calc3(){
const valorIni= Number(prompt("Favor Informar o Valor Inicial: "))
const juros = Number(prompt("Favor Informar o juros do cupom: "))
const ipcaAtual = Number(prompt("Favor Informe o ipca atual:"))
const tempo = Number(prompt("Favor Informar o Tempo em Anos "))
const juros2 = juros/100
const ipcaAtual2 = ipcaAtual/100
const somajuros = juros2+ipcaAtual2
const calculo3 = valorIni*(1+somajuros)**tempo
console.log("O Valor em R$",Math.floor(calculo3))
}
