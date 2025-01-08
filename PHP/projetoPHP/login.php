<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sistema</title>
    <!-- CDN do Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Option 1: Include in HTML -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css">

    <style>
        /* Adiciona uma imagem de fundo */
        body {
            background-image: url(''); /* Troque pela URL da imagem desejada */ /* Trocar imagem*/ 
            background-size: cover;
            background-position: center;
            height: 100vh;
            margin: 0;
        }

        /* Centralizando a div de login */
        .login-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .form-container {
            background-color: rgba(255, 255, 255, 0.8); /* Fundo branco semi-transparente */
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px; /* Limita o tamanho máximo do formulário */
        }

        .jumbotron {
            background-color: #007bff; /* Ajusta a cor de fundo da jumbotron */
        }
    </style>
</head>
<body>

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container-fluid">
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Alternar navegação">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="index.html"><i class="bi bi-house">Inicio</i></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="login.php"><i class="bi bi-youtube"></i>Canal da Empresa</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="login-container">
        <div class="form-container">
            <h2 class="text-center">Login</h2>
            <form action="login.php" method="POST">
                <div class="form-group">
                    <label for="usuario">Usuário</label>
                    <input type="text" class="form-control" id="usuario" name="usuario" placeholder="Usuário" required>
                </div>
                <div class="form-group">
                    <label for="senha">Senha</label>
                    <input type="password" class="form-control" id="senha" name="senha" placeholder="Senha" required>
                    <small id="emailHelp" class="form-text text-muted"><p class="text-danger">Favor usar senha forte</p></small>
                </div>
                <button type="submit" class="btn btn-primary btn-block">Entrar</button>
            </form>
            <div class="d-flex justify-content-center">
                <p><a href="cadastro.html">Cadastro</a></p>
            </div>
        </div>
    </div>

    <div class="jumbotron text-center bg-primary text-white py-5">
        <h1 class="display-4"><p class="text-dark">Duvidas? Favor entrar em contato com RH</p></h1>
    </div>

    <footer class="bg-dark text-white text-center py-5">
        <p>&copy; 2025 Minha Página. Todos os direitos reservados.</p>
    </footer>

    <!-- CDN do Bootstrap (Javascript) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
