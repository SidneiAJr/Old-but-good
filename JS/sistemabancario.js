let saldo = 0;
function deposito(){
   let entradavalor = document.getElementById("valor").value;
   if(entradavalor>0){
    document.getElementById("res").innerHTML = `Valor Depositado com sucesso R$ ${entradavalor}`
    let emprestimo =  entradavalor*0.30;
    document.getElementById("res2").innerHTML = `Limite Disponivel para emprestimo R$ ${emprestimo}`
   }else{
    document.getElementById("res").innerHTML = `Favor Informar o Numero correto!!`
   }
   saldo()
}
function sacar(){
    let entradavalor = parseFloat(document.getElementById("valor").value);  // Converte o valor para número
    if (entradavalor > 0 && entradavalor <= saldo) {  // Verifica se o valor é positivo e se há saldo suficiente
        saldo -= entradavalor;  // Atualiza o saldo após o saque
        document.getElementById("res").innerHTML = `Saque de R$ ${entradavalor.toFixed(2)} realizado!`;
        document.getElementById("res2").innerHTML = `Saldo Atual: R$ ${saldo.toFixed(2)}`;
    } else {
        document.getElementById("res").innerHTML = `Saldo insuficiente ou valor inválido!`;
    }
}
function aplicacao(){
    let entradavalor = document.getElementById("valor").value;
    if(entradavalor>0){
        saldo -= entradavalor;
    let aplicacao = entradavalor * (1+0.15)**1;
    let aplicacao2 = entradavalor * (1+0.15)**2;
        document.getElementById("res").innerHTML = `Saldo Disponivel R$ ${entradavalor}`
        document.getElementById("res2").innerHTML = `Valor Aplicado a Juros de 15% por 1 Ano ${aplicacao.toFixed(2)}`
        document.getElementById("res3").innerHTML = `Valor Aplicado a Juros de 15% por 2 Ano ${aplicacao2.toFixed(2)}`
       }else{
        document.getElementById("res").innerHTML = `Favor Informar o Numero correto!!`
       }
}
