
def insira_info():
    nome = input("Olá Insira seu nome: ")
    idade = int(input("Oá Insira sua idade: "))
    user = input("Por favor insira seu usuario: ")
    ensinomedio = input("Voce completou o ensino medio?S/N")
    print("Olá" ,nome,"Idade",idade,"usuario é",user)
    if idade>18:
        print("Voce pode fazer carteira de motora!")
    else:
       print("Voce não pode fazer carteira de motora!")
    if ensinomedio == "sim":
        print("Voce completou o ensino medio!")
    else:
        print("Voce não completou o ensino medio!")
    
    
    
insira_info()
