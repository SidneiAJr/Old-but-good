program teste;

uses crt;

var
v1,v2,v3,res,res2,res3,res4: integer;

Begin
clrscr;
Write('Por favor insira sua nota:');
Readln(v1);
Write('Por favor insira sua nota:');
Readln(v2);
Write('Por favor insira sua nota:');
Readln(v3);

res:=v1+v2+v3;
Write('O total é: ',res);
res2:=v1*v2;
res3:=v1-100;
res4:=v1/10;
Write('O total é: ',res2);
Write('O total é: ',res3);
Write('O total é: ',res4);


 
end.
