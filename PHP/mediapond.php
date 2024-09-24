<?php 
	
// Simple example prompting the user for their name 
$nome = readline("Por favor coloque seu nome:  "); 
$nota1  = (int)readline("Insira a nota1");
$nota2 = (int)readline("Insira a nota2");
$resultado = $nota1+$nota2;


echo "O Valor de sua media é: $resultado";

if ($nome !== "") { 
	echo "Ola, $nome! Bem vindo  "; 
} else { 
	echo "Por favor insira um Nome valido  "; 
} 
if ($resultado>5 ) { 
	echo "Aluno Aprovado!"; 
} else { 
	echo "Aluno Reprovado!"; 
} 

?>
