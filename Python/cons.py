import sqlite3
from sqlite3 import Error

def conexaobanco():
    caminho="C:\\Users\\paodemedoX\\Desktop\\testepy\\teste.db"
    con=None
    try:
        con=sqlite3.connect(caminho)
    except Error as ex:
        print(ex)
    return con
vcon=conexaobanco()

nome=input("Digite o Nome:")
telefone=input("Digite o Telefone:")
email=input("Digite o Nome:")

vsql="INSERT INTO tb_contatos(T_NOMECONTATO,T_TELEFONE,T_EMAILCONTATO)VALEUS('"+nome+"','"+telefone+"','"+email+"')"
def inserir(conexao,sql):
    try:
        c=conexao.cursor()
        c.execute(sql)
        conexao.commit()
        print("Registro recebido com sucesso")
    except Error as ex:
        print(ex)
        inserir(vcon,vsql)