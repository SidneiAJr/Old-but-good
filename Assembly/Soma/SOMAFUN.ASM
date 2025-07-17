%INCLUDE "io.inc"

SECTION .data
    num1 DD 0     ;numero 1  
    num2 DD 10    ;numero 2
    num3 DD 10    ;numero 3
    soma DD 00   ; soma
    subtra DD 00 ; Subtração
    

SECTION .text
GLOBAL main         ; ponto de entrada da função

main:
    MOV EAX, [num1]  ; VALOR DA VARIAVEL NUM 1   
    MOV EBX, [num2]  ; VALOR DA VARIAVEL NUM 2
    MOV ECX, [num3]  ; VALOR DA VARIAVEL NUM 3  
    ADD EAX, EBX
    ADD EBX , ECX
    MOV[soma],ebx
    MOV[subtra],ecx
    PRINT_UDEC 4, soma
    MOV ECX, 0 
    RET
   
