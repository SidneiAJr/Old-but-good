section .data
    msg db "Hello world!", 0ah
    msg2 db "Ola Bem vindo ao sistema",0ah

section .text
    global _start

_start:
    mov rax, 1
    mov rdi, 1
    mov rsi, msg
    mov rdx, 14
    syscall
    mov rax, 1
    mov rdi, 1
    mov rsi, msg2 
    mov rdx, 26 ; Chamada de Bloco usar syscall para chamadas
    syscall
    mov rax, 60
    mov rdi, 0
    syscall
