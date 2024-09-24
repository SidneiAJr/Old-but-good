import sqlite3

banco = sqlite3.connect('Primeiro_banco.db')

cursor = banco.cursor()
#cursor.execute("CREATE TABLE cadastros(nome text,idade integer,email text)") **Cria Tabela
#cursor.execute("INSERT INTO cadastros VALUES('Maria6',40,'teste@teste.com')") **Insere Valor na tabela
cursor.execute("SELECT * FROM cadastros")
print(cursor.fetchall())


banco.commit()
