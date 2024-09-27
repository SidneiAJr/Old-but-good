let pessoa = prompt("Voce concluiu o ensino medio: ")
let pessoa2 = prompt("Quantos anos voce tem?: ")
let pessoa3 = prompt("Voce cursa outra faculdade?:")

if(!pessoa){
    console.log("Voce ainda não completou o ensino medio:")
}
if(!pessoa3){
    console.log("Voce ainda não completou o ensino medio:")
}
if(!pessoa2){
    console.log("Voce ainda não completou 18 anos, e não pode ingressar na faculdade.")
}
if(pessoa2<18){
    console.log("Voce ainda não completou 18 anos!")
}
