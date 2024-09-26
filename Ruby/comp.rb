
print 'Digite um numero:'
n1 = gets.chomp.to_i
print 'Digite um numero:'
n2 = gets.chomp.to_i
print 'Digite um numero:'
n3 = gets.chomp.to_i
comp=n1>n2
comp2=n2>n1
comp3=n3>n1
comp4=n1>n3
comp5=n3>n1
comp6=n1 === n3
comp7=n1<n3
comp8=n1==n3
comp9=n3=>n1
comp10=n1*n2%5
comp11=n1>=n2

puts "A comparação é: #{comp}"
puts "A comparação é: #{comp2}"
puts "A comparação é: #{comp3}"
puts "A comparação é: #{comp4}"
puts "A comparação é: #{comp5}"
puts "A comparação é: #{comp6}"
puts "A comparação é: #{comp7}"
puts "A comparação é: #{comp8}"
puts "A comparação é: #{comp9}"
puts "A comparação é: #{comp10}"
puts "A comparação é: #{comp11}"


