section .data
    num1 DD 30          ; número 1
    num2 DD 70          ; número 2
    num3 DD 99          ; número 3
    soma DD 00          ; variável para armazenar a soma
    subtracao DD 00     ; variável para armazenar a subtração

section .text
    global main         ; ponto de entrada da função

main:
    ; Carregar valores de num1, num2 e num3 nos registradores
    mov eax, [num1]     ; movendo o valor de num1 (30) para eax
    mov ebx, [num2]     ; movendo o valor de num2 (70) para ebx
    mov ecx, [num3]     ; movendo o valor de num3 (99) para ecx

    ; Realizando a soma (eax + ebx)
    add eax, ebx        ; soma eax (30) com ebx (70)
    mov [soma], eax     ; armazena o resultado (100) em soma

    ; Realizando a subtração (eax - ecx)
    sub eax, ecx        ; subtrai ecx (99) de eax (100)
    mov [subtracao], eax ; armazena o resultado (1) em subtracao

    ; Finalizando o programa com retorno
    mov eax, 0          ; código de retorno 0
    ret                 ; retorna para o sistema operacional
