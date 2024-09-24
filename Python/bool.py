media1 = int(input("Por Favor Insira a Nota 1:"))
media2 = int(input("Por Favor Insira a Nota 2:"))
media3 = float(input("Por Favor Insira a Nota 3:"))

mediatotal = (media1+media2+media3)/3
media4 = mediatotal > 5
media5 = mediatotal < 5
media6 = mediatotal == 5
media7 = mediatotal <= 8
media8 = mediatotal >= 9

print(mediatotal)
print(media4)
print(media5)
print(media6)
print(media7)
print(media8)

if mediatotal > 6:
    print("Aprovado")
else:
    print("Aluno Reprovado")
