
print 'Digite sua nota:'
n1 = gets.chomp.to_i
print 'Digite sua nota:'
n2 = gets.chomp.to_i
print 'Digite sua nota:'
n3 = gets.chomp.to_i
res = (n1+n2+n3)/3
puts "Sua media é: #{res}"
if res >= 5
    puts "Aluno Aprovado"
elsif res < 4 
    puts "Aluno em Recuperação"
else
    puts "Aluno Reprovado"
end
