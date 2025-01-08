use std::io;

fn main() {
    let mut nota1 =String::new();
    let mut nota2=String::new();
    let mut nota3=String::new();

    println!("Digite o primeiro número:");
    io::stdin().read_line(&mut nota1).expect("Falha ao ler a linha");

    println!("Digite o segundo numero:");
    io::stdin().read_line(&mut nota2).expect("Falha ao ler a linha");

    println!("Digite o terceiro numero:");
    io::stdin().read_line(&mut nota3).expect("Falha ao ler a linha");

    let nota1: i32 = nota1.trim().parse().expect("Por favor, insira um número válido");
    let nota2: i32 = nota2.trim().parse().expect("Por favor, insira um número válido");
    let nota3: i32 = nota3.trim().parse().expect("Por favor, insira um número válido");
    
    let res = nota1+nota2+nota3;

    println!("O valor total será:{}",res);
}
