Nome = input('Por Favor Insira seu nome:')
Idade = float((input)('Por favor insira sua idade:'))

print('Bem vindo ao sistema: ', Nome)
print("Sua Idade é", Idade)
print('Maior De Idade' if Idade>=21 else 'Menor de Idade')
print('Pode Ter CNH' if Idade>=21 else 'Não Pode ter CNH')
