<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
<link rel="stylesheet" type="text/css" href="estilo.css" media="screen" />
<title>Sistema</title>
</head>
<body>
<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary" data-bs-theme="dark">
        <div class="container-fluid">
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
              <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="#"><i class="bi bi-house"></i></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#"><i class="bi bi-book"></i>Informações</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#"><i class="bi bi-rss"></i>Noticias</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#"><i class="bi bi-broadcast"></i>Radio</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="login.html"><i class="bi bi-person"></i>Login</a>
              </li>
            </ul>
            <form class="d-flex" role="search">
              <input class="form-control me-2" type="search" placeholder="" aria-label="Search">
              <button class="btn btn-outline-success" type="submit"><i class="bi bi-search"></i></button>
            </form>
          </div>
        </div>
      </nav>
  <div id="container">
  <form name="f_cad" method="post" action="reb_login.php">
    <label>Nome</label>
    <input type="text" name="f_nome" size="20"></br>
    <label>Senha</label>
    <input type="password" name="f_senha" size="20"></br>
    <input type="submit" value="Enviar"/>
    <input type="reset" value="Limpar"/>

</form>
</div>
</body>
</html>
