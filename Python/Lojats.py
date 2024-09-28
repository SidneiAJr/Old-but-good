print('Loja Teste dos Guri')
preço = float(input('Preço das compras : R$'))
print('''Formas de Pagamento
[ 1 ] á vista forma de pagamento:
[ 2 ] Parcelado em 1x:
[ 3 ] Parcelado em  2x ou mais
[ 4 ] Parcelado em 4x com juros 20%
''')
opçao = int(input("Qual seria a forma de pagamento:"))

if opçao == 1:
    total = preço - (preço * 10/ 100)
elif opçao == 2:
    total = preço - (preço * 5 / 100)
elif opçao == 3:
    total = preço
    parcela = total / 2
    print('Sua compra será parcelada em 2x de R${:.2f}'.format(parcela))
elif opçao == 4:
    total = preço + (preço * 20/100)
    totparc = int(input('Quantas Parecelas?'))
    parcela = total/totparc
    print('Sua compra será Parcelada em {}x de R${:.2f}Com juros'.format(totparc,parcela))
print('Sua compra de R${:.2f},vai custar R${:.2f},no final.'.format(preço,total))

    
 