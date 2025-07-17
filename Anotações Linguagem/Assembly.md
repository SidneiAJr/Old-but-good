📌 1. Registradores (x86 - 32 bits)

Registradores são pequenas áreas de armazenamento extremamente rápidas dentro da CPU. Eles são usados para guardar dados temporários durante a execução de instruções.

Registrador	Função principal

EAX	Acumulador – usado em operações aritméticas e de retorno de funções.

EBX	Base – registrador de uso geral.

ECX	Contador – comumente usado em loops e deslocamentos.

EDX	Dados – também de uso geral, mas útil em operações de multiplicação e divisão.

ESP	Stack Pointer – aponta para o topo da pilha.

EBP	Base Pointer – usado para acessar parâmetros da pilha.

EIP	Instruction Pointer – aponta para a próxima instrução a ser executada.

📝 Nota: Em sistemas de 64 bits, os registradores se chamam RAX, RBX, etc.

⚙️ 2. Instruções Comuns (Assembly x86)

Aqui estão as instruções mais utilizadas e suas funções:

Instrução	Descrição

MOV	Copia dados entre registradores, memória ou valores imediatos. Ex: MOV EAX, 5

ADD	Soma dois valores. Ex: ADD EAX, EBX

SUB	Subtrai um valor de outro. Ex: SUB ECX, 1

MUL	Multiplica (resultado pode ocupar dois registradores). Ex: MUL EBX

DIV	Divide (também afeta múltiplos registradores). Ex: DIV ECX

PUSH	Coloca um valor na pilha. Ex: PUSH EAX

POP	Remove o topo da pilha e coloca no registrador. Ex: POP EBX

JMP	Salto incondicional. Ex: JMP loop_inicio

JE, JNE	Saltos condicionais: Jump if Equal / Not Equal. Usam o resultado da última comparação (CMP).

INT	Chama uma interrupção do sistema (usado para I/O, etc). Ex: INT 0x80 no Linux.
