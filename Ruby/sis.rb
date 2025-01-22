def im ()
    print "oi"
end

def calc()
    print "Insira a nota: "
    n1 = gets.chomp.to_i
    print "Insira a nota: "
    n2 = gets.chomp.to_i
    print "Insira a nota: "
    n3 = gets.chomp.to_i
    res = n1+n2+n3
    print "Insira a nota #{res}"
end

def vf()
    print "Insira o val inicial: "
    vl = gets.chomp.to_f
    print "insira o tempo: "
    tm = gets.chomp.to_i
    print "Insira o juros: "
    jr = gets.chomp.to_f
    divjr = jr/100
    vf = vl*(1+divjr)**tm
    print "O valor futuro será: %.2f" % vf
end

puts "Selecione uma opção:"
puts "1 - Calcular valor futuro"
puts "2 - Calcular soma de notas"
print "3- Função Batata"
ops = gets.chomp.to_i
case ops
when 1
  puts "Calcular valor futuro"
  vf()
when 2
  puts "Calcular soma de notas"
  calc()
when 3
    print "Função batata"
else
  puts "Opção inválida!"
end
