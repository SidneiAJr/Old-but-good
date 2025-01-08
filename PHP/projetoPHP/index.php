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
</head>
<body>
    <!-- Barra de navegação -->
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
            </div>
        </div>
    </nav>
    <div class="jumbotron text-center bg-primary text-white py-5">
        <h1 class="display-4"><i class="bi bi-rocket-takeoff"></i><p class="text-danger">Bem Vindo</p><i class="bi bi-rocket-takeoff"></i></h1>
        <h4><p class="text-dark">Selecione a Opção Desejada</p></h4>
    </div>
    <div class="container py-4">
        <div class="row">
            <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Contracheque</h5>
                        <a class="btn btn-dark btn-lg" href="login.php"role="button">Contracheque</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Informações</h5>
                        <a class="btn btn-dark btn-lg" href="cadastro.php" role="button"><i class="bi bi-person-fill-gear"></i></i>Informações</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Fale Com RH</h5>
                        <a class="btn btn-dark btn-lg" href="cadastro.php" role="button"><i class="bi bi-person-fill-gear"></i></i>Falar com RH</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Abrir chamado</h5>
                        <a class="btn btn-dark btn-lg" href="cadastro.php" role="button"><i class="bi bi-person-fill-gear"></i></i>Chamados</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Canal da Empresa Youtube</h5>
                        <a class="btn btn-dark btn-lg" href="" role="button"><i class="bi bi-person-fill-gear"></i></i>Canal</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Vagas Internas</h5>
                        <a class="btn btn-dark btn-lg" href="cadastro.php" role="button"><i class="bi bi-person-fill-gear"></i></i>Vagas</a>
                    </div>
                </div>
            </div>
            </div>

        </div>
    </div>
    <div class="jumbotron text-center bg-primary text-white py-5">
        <h1 class="display-4"><p class="text-dark">Duvidas? Favor entrar em contato com RH</p></h1>
    </div>

    <!-- Rodapé -->
    <footer class="bg-dark text-white text-center py-5">
        <p>&copy; 2025 Minha Página. Todos os direitos reservados.</p>
    </footer>
    <footer class="bg-dark text-white text-center py-5">
        <a class="btn btn-dark btn-lg" href="login.html" role="button"><i class="bi bi-person-fill-gear"></i></i>Sair</a>
    </footer>

</body>
</html>
