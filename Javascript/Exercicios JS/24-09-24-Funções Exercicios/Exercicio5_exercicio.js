function operacao(){
    let n1 = prompt("Por favor digite um numero: ")
    let n2 = prompt("Por favor digite um numero: ")
    let soma = n1 +n2
    let div = n1/n2
    let mult = n1*n2
    let sub = n1-n2
    let numero = (`Os numeros digitais são:${n1} e ${n2}`)
    console.log(numero)
    console.log("Soma"+soma)
    console.log("Divisão"+div)
    console.log("Multiplicacao"+mult)
    console.log("Subtração:",sub)
    
}
operacao(operacao.soma)
operacao(operacao.div)
operacao(operacao.mult)
operacao(operacao.sub)
operacao(operacao.numero)