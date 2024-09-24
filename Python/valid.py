sexo = str(input('Informe o Sexo:'))
print(sexo)
while sexo not in 'MmFf':
    sexo = str(input('Dados Invalidos, Por Favor Informe corretamente.'))
print('sexo {} Registrado com sucesso'. format(sexo))

