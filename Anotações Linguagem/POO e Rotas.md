# 🐘 PHP – Rotas e Programação Orientada a Objetos (POO)

Este material contém anotações e exemplos de como usar **rotas simples** e **POO (Programação Orientada a Objetos)** em PHP puro, sem frameworks.

---

## 🔁 Rotas Simples com PHP

> Em PHP puro, o controle de rotas geralmente é feito através do `$_SERVER['REQUEST_URI']`.

### 📂 Estrutura de arquivos sugerida:

```
/projeto/
├── index.php
└── paginas/
    ├── home.php
    ├── sobre.php
    └── contato.php
```

### 📄 index.php (roteador básico)

```php
<?php

$rota = $_SERVER['REQUEST_URI'];

switch ($rota) {
    case '/':
        include 'paginas/home.php';
        break;
    case '/sobre':
        include 'paginas/sobre.php';
        break;
    case '/contato':
        include 'paginas/contato.php';
        break;
    default:
        http_response_code(404);
        echo "Página não encontrada!";
        break;
}
?>
```

---

## 🎯 POO – Programação Orientada a Objetos no PHP

### 🔹 Classe Simples com Construtor

```php
<?php

class Usuario {
    public $nome;

    public function __construct($nome) {
        $this->nome = $nome;
    }

    public function dizerOla() {
        return "Olá, " . $this->nome;
    }
}

$usuario = new Usuario("Carlos");
echo $usuario->dizerOla(); // Saída: Olá, Carlos

?>
```

---

### 🔒 Encapsulamento

```php
<?php

class Conta {
    private $saldo = 0;

    public function depositar($valor) {
        if ($valor > 0) {
            $this->saldo += $valor;
        }
    }

    public function verSaldo() {
        return $this->saldo;
    }
}

$conta = new Conta();
$conta->depositar(150);
echo $conta->verSaldo(); // Saída: 150

?>
```

---

### 🧬 Herança

```php
<?php

class Animal {
    public function falar() {
        return "Som genérico";
    }
}

class Cachorro extends Animal {
    public function falar() {
        return "Latido!";
    }
}

$pet = new Cachorro();
echo $pet->falar(); // Saída: Latido!

?>
```

---

## 📦 Namespace e Organização de Classes

### 🗂 Exemplo de estrutura com Composer:

```
/src/
└── Model/
    └── Produto.php
```

### 📄 src/Model/Produto.php

```php
<?php

namespace App\Model;

class Produto {
    public $nome = "Notebook";
}
```

### 📄 composer.json

```json
{
  "autoload": {
    "psr-4": {
      "App\\": "src/"
    }
  }
}
```

> Após configurar, execute:
```bash
composer dump-autoload
```

### 📄 index.php (uso com autoload)

```php
<?php

require 'vendor/autoload.php';

use App\Model\Produto;

$produto = new Produto();
echo $produto->nome;

?>
```

---

## ✅ Conclusão

- PHP oferece suporte completo à Programação Orientada a Objetos
- Mesmo sem frameworks, é possível organizar bem seu projeto com namespaces e roteamento
- Para projetos maiores, considere migrar para um framework como Laravel ou Slim para abstrair essa estrutura manual

---
