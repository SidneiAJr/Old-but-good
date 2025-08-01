# 🐘 PHP – Rotas e Programação Orientada a Objetos (POO)

Este material contém anotações e exemplos de como usar **rotas simples** e **POO (Programação Orientada a Objetos)** em PHP puro, sem frameworks.

---

## 🔁 Rotas Simples com PHP

> Em PHP puro, o controle de rotas geralmente é feito através do `$_SERVER['REQUEST_URI']`.

### 📂 Estrutura de arquivos:


### 📄 index.php (roteador)
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
echo $pet->falar(); // Latido!
// src/Model/Produto.php
namespace App\Model;

class Produto {
    public $nome = "Notebook";
}
