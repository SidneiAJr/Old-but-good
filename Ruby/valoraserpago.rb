print '=========================/'
puts "/n"
print 'Digite o Valor da entrada'
n1 = gets.chomp.to_i
print 'Digite o Numero de parcelas'
n2 = gets.chomp.to_i
total =n1*n2
if total>50
    print 'Transação Aprovada'
else
    print'Transação recusada'
end    

print '========================='

puts "O Valor total a ser pago é: #{total}"


