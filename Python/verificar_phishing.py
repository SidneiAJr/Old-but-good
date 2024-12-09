# Função para verificar se o corpo do e-mail contém palavras suspeitas de phishing
def verificar_phishing(mensagem):
    # Lista de palavras que indicam possíveis e-mails de phishing
    palavras_suspeitas = ["ganhe", "prêmio", "urgente", "desconto", "click",  "promoção"]
    
    # TODO: Verifique se alguma palavra suspeita está presente no corpo do e-mail:
    if(email_usuario=="ganhe",email_usuario=="prêmio",email_usuario=="desconto",email_usuario=="click",email_usuario=="promoção"):
      print('Classificação: Phishing')
    else:
      print('Classificação: Seguro')
    
        
            
        
email_usuario = input()

email_usuario = email_usuario.strip()

resultado = verificar_phishing(email_usuario)

print(f"Classificação: {resultado}")
