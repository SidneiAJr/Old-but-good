import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.println("Digite a Opção:  ");
        int opcao = entrada.nextInt();
        double salario = 0;

        switch (opcao) {
            case 1:
                salario = sacar(salario, entrada);
                break;
            case 2:
                salario = Info(salario, entrada);
                break;
            default:
                System.out.println("Opção inválida.");
        }
    }

    // Função para realizar o saque e diminuir o salário
    public static double sacar(double salario, Scanner entrada) {
        System.out.println("Bem-vindo ao programa!");
        System.out.println("Por Favor, Informe seu Nome:");
        String nome = entrada.next();  // Usa o mesmo Scanner para entrada
        System.out.println("Por Favor, Informe o Valor da Retirada:");
        double retirada = entrada.nextDouble();
        if (retirada <= salario) {
            salario -= retirada;
            System.out.println("Retirada de R$ " + String.format("%.2f", retirada) + " realizada com sucesso!");
            System.out.println("Seu novo saldo é: R$ " + String.format("%.2f", salario));
        } else {
            System.out.println("Saldo insuficiente para a retirada.");
        }
        return salario;
    }

    public static double Info(double salario, Scanner entrada) {
        System.out.println("Bem-vindo ao programa!");
        System.out.println("Por Favor, Informe seu Nome:");
        String nome = entrada.next();
        System.out.println("Informe Seu Salário:");
        salario = entrada.nextDouble();
        System.out.println("Informe sua idade:");
        int idade = entrada.nextInt();
        double emprestimo = salario * 0.30;
        System.out.println("Temos uma oferta para você de R$ " + String.format("%.2f", emprestimo));
        System.out.println("Olá " + nome + ", bem-vindo!");
        System.out.println("Saldo disponível: R$ " + String.format("%.2f", salario));
        return salario;
    }
}
