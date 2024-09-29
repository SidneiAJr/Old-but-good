program inputador

   real :: var1,var3,var4
   real :: res
   
   print *, 'Por Favor digite um numero'
   read *, var1,var3,var4
   res = var1+var3+var4
   res2 = var1+var3+var4/3
   print *, 'O total é:', res
   print *, 'O total é:', res2
   if(res2>6)then
   print *, 'O Aluno esta Aprovado'
   stop
   else
   print *, 'O Aluno esta reprovado'
   stop
   end if
 
   

end program inputador
