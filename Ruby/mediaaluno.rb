print 'Digite seu Nome:'
name = gets.chomp
print "Digite sua idade:"
idade = gets.chomp.to_i
print 'Digite a primeira nota da avaliação:'
nota1 = gets.chomp.to_i
print 'Digite a Segunda nota da avaliação:'
nota2 = gets.chomp.to_i
print 'Digite a Terceira nota da avlaiação:'
nota3 = gets.chomp.to_i
media = (nota1+nota2+nota3)/3
if media > 6 
  puts "Voce foi Aprovado"
else
  puts "Voce foi reprovado"
end

puts "Olá:  #{name}!"
puts "Sua Idade é: #{idade}"
puts "Sua media é: #{media}"
