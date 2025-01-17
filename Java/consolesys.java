 public static void calc1(){
        Scanner entrada = new Scanner(System.in);
        double valorIni;
        System.out.print("Digite o valor inicial: ");
        valorIni=entrada.nextDouble();
        int tempo;
        System.out.print("Digite o tempo em anos: ");
        tempo=entrada.nextInt();
        double juros;
        System.out.print("Juros %: ");
        juros=entrada.nextDouble();
        double vf;
        double divjuros = juros/100;
        
        vf = valorIni * Math.pow((1 + divjuros), tempo);
        System.out.print("Valor futuro:"+ vf);
       //classe para calculadora de vf//  
    }
    public static void juros(){
        Scanner entrada = new Scanner(System.in);
        double rend;
        System.out.print("Digite o valor do rendimento: ");
        rend=entrada.nextDouble();
        double valorApli;
        System.out.print("Digite o valor do investimento inicial: ");
        valorApli=entrada.nextDouble();
        double res;
        res = (rend*100)/valorApli;
        System.out.print("O juros atual é: "+res);
    }
    public static void cad(){
     
        Scanner reb = new Scanner(System.in);
        String nome;
        System.out.print("Digite seu nome: ");
        nome = reb.nextLine();
        String sobrenome;
        System.out.print("Digite seu sobrenome: ");
        sobrenome = reb.nextLine();
        String tel;
        System.out.print("Digite seu Telefone: ");
        tel = reb.nextLine();
        String matricula;
        System.out.print("Digite seu Matricula: ");
        matricula = reb.nextLine();
        String salario;
        System.out.print("Digite seu Salario: ");
        salario = reb.nextLine();
        
        String[] info = {nome , sobrenome,tel,matricula,salario};
        System.out.println("Olá Bem vindo: " + info[0] + " " + info[1]+ "Telefone: " + info[2]+ "Matricula: "+ info[3]+"Salario R$:"+ info[4]);
    }
    
    public static void main(String[] args) {
      
    int op;
    Scanner entrada = new Scanner(System.in);
    System.out.print("Digite uma opcao : ");
    op=entrada.nextInt();
    
    switch(op){
        case 1:
        calc1();
        break;
        case 2:
        juros();
        break;
        case 3:
        cad();
        break;
        default:
        System.out.println("Opção inválida!");
        break;
   
       
       
    }
        
        
        
    }
    
}
