import urllib.request 

pagina=urllib.request.urlopen("")
texto=pagina.read().decode("utf8")

dado=texto[0:15]
print(dado)