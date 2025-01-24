puts "Bem vindo a tabuada"
num = gets.chomp.to_i

puts "A Tabuada  do #{num} é:"

for i in 0..10
    puts "#{num} x #{i} = #{num *i}"
end  
