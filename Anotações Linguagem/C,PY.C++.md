# 📚 Repositório de Programação | Estudo | Fique à Vontade

Este repositório contém anotações e exemplos simples sobre linguagens de programação que estou estudando. Sinta-se livre para explorar, sugerir melhorias ou usar como base para seus estudos.

---

## 🟦 C# – Anotações

### 🔸 Tipos de Variáveis:
- `int`, `float`, `double`, `decimal`
- `bool`, `char`, `string`
- `DateTime`

### 🔸 Array:
```csharp
int[] numeros = new int[5];
```

### 🔸 Lista (dinâmica):
```csharp
List<int> lista = new List<int>();
lista.Add(valor);                // Adiciona no final
lista.Insert(posicao, valor);    // Adiciona na posição específica
lista.AddRange(outraLista);      // Adiciona vários elementos no final
```

---

## ☕ Java – Anotações

### 🔸 Tipos de Variáveis:
- `int`, `float`, `double`
- `boolean`, `char`, `String`
- `Date`

### 🔸 Array:
```java
int numeros[] = new int[5];
```

### 🔸 ArrayList (dinâmica):
```java
ArrayList<Integer> lista = new ArrayList<>();
lista.add(valor);                     // Adiciona no final
lista.add(posicao, valor);            // Adiciona na posição específica
lista.addAll(outraLista);             // Adiciona vários elementos no final
```

---

## 🟨 JavaScript – Anotações

### 🔸 Tipos de Variáveis:
- `var`, `let`, `const`

### 🔸 Comandos para Adicionar em Arrays:
- `push(valor)` → Adiciona no final
- `unshift(valor)` → Adiciona no início
- `splice(índice, 0, valor)` → Adiciona em uma posição específica
- `concat(array2)` → Retorna um novo array juntando os dois
- `[...arr, valor]` → Spread: adiciona no final
- `[valor, ...arr]` → Spread: adiciona no início

---

## 💻 C – Anotações

### 🔸 Tipos de Variáveis:
- `int`, `float`, `double`, `char`
- `void`, `long`, `short`

### 🔸 Array:
```c
int numeros[5];
```

### 🔸 Estruturas:
```c
struct Pessoa {
    char nome[50];
    int idade;
};
```

### 🔸 Ponteiros:
```c
int a = 10;
int* p = &a;
```

---

## 🐍 Python – Anotações

### 🔸 Tipos de Variáveis:
- `int`, `float`, `str`, `bool`
- `list`, `dict`, `set`, `tuple`

### 🔸 Lista (dinâmica):
```python
numeros = []
numeros.append(valor)       # Adiciona no final
numeros.insert(pos, valor)  # Adiciona na posição específica
numeros.extend([1, 2, 3])   # Adiciona vários elementos no final
```

### 🔸 Dicionário:
```python
pessoa = {"nome": "João", "idade": 25}
```

### 🔸 Função:
```python
def soma(a, b):
    return a + b
```

---

## 🧩 C++ – Anotações

### 🔸 Tipos de Variáveis:
- `int`, `float`, `double`, `char`, `bool`, `string`
- `long`, `short`, `auto`

### 🔸 Array:
```cpp
int numeros[5];
```

### 🔸 Vector (dinâmico):
```cpp
#include <vector>
std::vector<int> numeros;
numeros.push_back(valor);              // Adiciona no final
numeros.insert(numeros.begin()+pos, v); // Adiciona na posição específica
numeros.insert(numeros.end(), lista.begin(), lista.end()); // Adiciona vários
```

### 🔸 Classe:
```cpp
class Pessoa {
public:
    string nome;
    int idade;

    void apresentar() {
        std::cout << "Nome: " << nome << std::endl;
    }
};
```

---

## 🔁 Estruturas de Controle (C / Python / C++ / C# / Java / JS)

### Condicional:
```c
if (condicao) {
    // código
} else if (condicao) {
    // outro código
} else {
    // código final
}
```

```python
if cond:
    # Python
elif outra_cond:
    pass
else:
    pass
```

### Switch:
```c
switch (valor) {
    case X:
        // ação
        break;
    default:
        // ação padrão
        break;
}
```

### Laços:
```c
for (int i = 0; i < 10; i++) {
    // loop
}

while (condicao) {
    // loop
}

do {
    // loop
} while (condicao);
```

```python
for i in range(10):
    pass

while cond:
    pass
```

---

## ⚙️ Operadores Comuns

| Operador | Descrição              | Exemplo             |
|----------|------------------------|---------------------|
| `+`      | Soma / Concatenação    | `a + b`             |
| `-`      | Subtração              | `a - b`             |
| `*`      | Multiplicação          | `a * b`             |
| `/`      | Divisão                | `a / b`             |
| `%`      | Resto da divisão       | `a % b`             |
| `==`     | Igualdade              | `a == b`            |
| `!=`     | Diferente              | `a != b`            |
| `<` `>`  | Menor / Maior          | `a < b`, `a > b`    |
| `&&` `||`| E / OU lógico (C/C++)  | `a && b`, `a || b`  |
| `and` `or`| E / OU lógico (Python)| `a and b`, `a or b` |
| `!` `not`| Negação                | `!a`, `not a`       |

---

## ✏️ Para Estudar Futuramente

- 🔹 Funções e Métodos
- 🔹 Structs (C) e Classes (C++/C#)
- 🔹 Orientação a Objetos em Python / C++ / Java / C#
- 🔹 Ponteiros e Alocação Dinâmica (C / C++)
- 🔹 Manipulação de Arquivos
- 🔹 Módulos e Bibliotecas Externas
- 🔹 Compilação, Makefile, Build
- 🔹 Banco de Dados (SQLite / arquivos / ORM)
- 🔹 APIs e Requisições HTTP

---

📌 **Obs:** Esse repositório é um espaço pessoal de estudo, mas sinta-se livre para usar, compartilhar ou contribuir se quiser. 🙌
