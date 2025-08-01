
# 🐘 PHP – Anotações e Exemplos

Este repositório contém anotações, trechos de código e boas práticas sobre a linguagem PHP. Ideal para quem está começando no desenvolvimento web backend com PHP ou quer revisar fundamentos.

---

## 📌 Conceitos Básicos

### 🔸 Variáveis:
```php
$nome = "Pedro";
$idade = 18;
$ativo = true;
```

### 🔸 Tipos de Dados:
- `string`
- `int`
- `float`
- `bool`
- `array`
- `object`
- `null`

### 🔸 Concatenação:
```php
echo "Olá, " . $nome;
```

---

## 🔁 Estruturas de Controle

### Condicional:
```php
if ($idade >= 18) {
    echo "Maior de idade";
} else {
    echo "Menor de idade";
}
```

### Switch:
```php
switch ($opcao) {
    case 1:
        echo "Opção 1";
        break;
    default:
        echo "Opção inválida";
}
```

### Laços:
```php
for ($i = 0; $i < 5; $i++) {
    echo $i;
}

while ($condicao) {
    // código
}

do {
    // código
} while ($condicao);
```

---

## 🔣 Arrays

### Simples:
```php
$frutas = ["Maçã", "Banana", "Laranja"];
echo $frutas[0]; // Maçã
```

### Associativo:
```php
$pessoa = [
    "nome" => "Ana",
    "idade" => 25
];
echo $pessoa["nome"];
```

### Funções úteis:
```php
count($array);
array_push($array, "Novo valor");
in_array("Valor", $array);
```

---

## 🧩 Funções

```php
function saudacao($nome) {
    return "Olá, $nome!";
}

echo saudacao("João");
```

---

## 🌐 Superglobais

- `$_GET` – dados enviados pela URL
- `$_POST` – dados enviados por formulário
- `$_REQUEST` – combinação de GET + POST
- `$_SESSION` – dados da sessão do usuário
- `$_COOKIE` – dados armazenados no navegador
- `$_FILES` – upload de arquivos
- `$_SERVER` – informações do servidor

---

## 💾 Conexão com MySQL (MySQLi)

### Conexão:
```php
$conn = new mysqli("localhost", "root", "", "banco");

if ($conn->connect_error) {
    die("Erro de conexão: " . $conn->connect_error);
}
```

### Inserção segura (prepared statement):
```php
$stmt = $conn->prepare("INSERT INTO usuarios (nome, email) VALUES (?, ?)");
$stmt->bind_param("ss", $nome, $email);
$stmt->execute();
```

---

## 🔐 Segurança com Senhas

### Gerar hash:
```php
$senhaHash = password_hash($senha, PASSWORD_DEFAULT);
```

### Verificar senha:
```php
if (password_verify($senhaDigitada, $senhaHashSalva)) {
    // Senha correta
}
```

---

## 📂 Trabalhar com Arquivos

```php
$conteudo = file_get_contents("arquivo.txt");
file_put_contents("arquivo.txt", "Novo conteúdo");
```

---

## 🧪 Boas Práticas

- Sempre use **`prepared statements`** contra SQL Injection.
- **Nunca salve senhas em texto puro.**
- Use `isset()` e `empty()` para validar dados do `$_POST` ou `$_GET`.
- Separar lógica de exibição (PHP) do HTML quando possível.
- Utilize `require_once` ou `include_once` para reutilizar arquivos.

---

## ✏️ Para Estudar Futuramente

- Orientação a Objetos em PHP
- PDO (PHP Data Objects)
- Sessões e autenticação
- Upload e validação de arquivos
- Criação de APIs REST com PHP
- Laravel e frameworks modernos

---

📌 **Obs:** PHP é amplamente utilizado para backend web. Ele alimenta plataformas como WordPress, Laravel e muitos sistemas personalizados. É leve, poderoso e bem documentado.
