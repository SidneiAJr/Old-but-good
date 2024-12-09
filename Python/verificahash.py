def verificar_hashes(lista_hashes):
    for hash_comparado in lista_hashes:
      
        hash_calcular , hash_esperado = hash_comparado.split(",")
        
        hash_calcular = hash_calcular.strip()
        hash_esperado = hash_esperado.strip()
        
        if hash_calcular == hash_esperado:
          print("Correto")
        else:
          print("Inválido")
hashes_usuario = input()

lista_hashes = hashes_usuario.split(";")

verificar_hashes(lista_hashes)
    
