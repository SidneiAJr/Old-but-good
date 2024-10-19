print 'Digite um Numero: '
n1 = gets.chomp.to_i

veripar = n1 %2  
veri = veripar == 0
print "E par seu numero: #{veri}"
