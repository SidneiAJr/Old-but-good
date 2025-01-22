ar = [1,2,3,4,5,7,8,9,10]
print ar
ar = [1,2,3,4,5,7,8,9,10]
ar.push(8,11)
print ar
ar = [1,2,3,4,5,7,8,9,10]
ar2= [1,2,3,4,5,7,8,9,10]
res = ar.zip(ar2).map{|a,b | a+b}
print res.inspect
