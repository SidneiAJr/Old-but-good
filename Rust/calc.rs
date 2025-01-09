use std::io;

fn main() {
    let mut valorini = String::new();
    let mut tempo = String:: new();
    let mut juros = String:: new();
    
    println!("Digite o Valor Inicial");
    io::stdin().read_line(&mut valorini).expect("Falha ao ler a linha: ");

    println!("Digite o tempo em anos");
    io::stdin().read_line(&mut tempo).expect("Falha ao ler a linha: ");

    println!("Digite o juros do cupom");
    io::stdin().read_line(&mut juros).expect("Falha ao ler a linha: ");

    let valorini: f32 = valorini.trim().parse().expect("Por favor, insira um número válido");
    let tempo: i32 = tempo.trim().parse().expect("Por favor, insira um número válido");
    let juros: f32 = juros.trim().parse().expect("Por favor, insira um número válido");
    
    let divjuros = juros / 100.0;
    
    let valor_final = valorini * (1.0 + divjuros).powi(tempo);
    
   println!("O valor final após {} anos será: {:.2}", tempo, valor_final);
}
