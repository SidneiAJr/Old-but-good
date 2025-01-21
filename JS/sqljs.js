// Importar módulos
const express = require('express');
const fileup = require('express-fileupload');
const mysql = require('mysql2');
const { engine } = require('express-handlebars');
const fs = require('fs'); // Importar o módulo fs para trabalhar com arquivos

// Configuração de conexão com o banco de dados
const conex = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: '',
  database: 'projeto'
});

// Testando a conexão com o banco de dados
conex.connect(function (erro) {
  if (erro) {
    console.log(erro);
    return;
  }
  console.log('Conexão com o banco de dados estabelecida com sucesso.');
});

const app = express();

// Configuração de manipulação de dados
app.use(express.json());
app.use(express.urlencoded({ extended: false }));

// Habilitando upload de arquivos
app.use(fileup());

// Adicionando Bootstrap e arquivos estáticos
app.use('/bootstrap', express.static('./node_modules/bootstrap/dist'));
app.use('/css', express.static('./css'));

// Refe a pasta img para imagens
app.use('/imagens', express.static('./imagens'));

// Configuração do handlebars
app.engine('handlebars', engine());
app.set('view engine', 'handlebars');
app.set('views', './views');

// Rota principal (formulário)
app.get('/', function (req, res) {
  let sql = 'SELECT * FROM produtos';
  conex.query(sql, function (erro, retorno) {
    res.render('formulario', { produtos: retorno });
  });
});

// Rota de cadastro
app.post('/cadastrar', async function (req, res) {
  try {
    // Obter dados para gravação
    let nome = req.body.nome;
    let valor = req.body.valor;
    let imagem = req.files.imagem.name;

    let sql = `INSERT INTO produtos(nome, valor, imagem) VALUES('${nome}', ${valor}, '${imagem}')`;

    // Execução do SQL
    conex.query(sql, async function (erro, retorno) {
      if (erro) {
        throw erro;
      }

      // Movendo a imagem para a pasta 'imagens'
      try {
        await req.files.imagem.mv(__dirname + '/imagens/' + req.files.imagem.name);
        console.log('Imagem carregada com sucesso.');
        res.redirect('/'); // Redireciona de volta para o formulário após o cadastro
      } catch (erro) {
        console.log('Erro ao mover a imagem:', erro);
        res.status(500).send('Erro ao salvar a imagem.');
      }
    });
  } catch (erro) {
    console.log('Erro no processo de cadastro:', erro);
    res.status(500).send('Erro ao cadastrar o produto.');
  }
});

// Rota remover produtos
app.get('/remover/:codigo/:imagem', function (req, res) {
  const { codigo, imagem } = req.params; // Capturando os parâmetros da URL

  // Deletando o produto do banco de dados
  let sql = `DELETE FROM produtos WHERE codigo = ?`;

  conex.query(sql, [codigo], function (erro, retorno) {
    // Caso falhe o comando SQL
    if (erro) {
      console.log('Erro ao excluir o produto:', erro);
      return res.status(500).send('Erro ao excluir o produto.');
    }

    // Caso o produto tenha sido excluído, removemos a imagem do diretório
    const caminhoImagem = __dirname + '/imagens/' + imagem;

    fs.unlink(caminhoImagem, function (erro_imagem) {
      if (erro_imagem) {
        console.log('Falha ao remover a imagem:', erro_imagem);
        return res.status(500).send('Erro ao remover a imagem.');
      }

      console.log('Produto e imagem removidos com sucesso!');
      res.redirect('/'); // Redireciona para a página inicial após a remoção
    });
  });
});


// Criando o servidor
app.listen(3020, () => {
  console.log('Servidor rodando na porta 3020');
});
