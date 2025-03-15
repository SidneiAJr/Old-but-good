section .data
    msg2 db "Ola Bem vindo ao sistema!",0ah
    result db "0", 0
section .bss
    soma1 resb 1
    soma2 resb 1
     res resb 1  ; Reservar 1 byte para armazenar o resultado da soma
section .text
    global _start
_start:
    mov byte [soma1] , 5
    mov byte [soma2] , 5
    mov al, [soma1]
    add al, [soma2]
    add al, '0'
    mov [res] , al
    mov rax , 1
    mov rdi, 1
    mov rsi, msg2
    mov rdx, 24
    syscall
    mov rax , 1
    mov rdi , 1
    mov rsi, res
    mov rdx , 1
    syscall
    mov rax , 60
    mov rdi , 0
    syscall
    
    
    
