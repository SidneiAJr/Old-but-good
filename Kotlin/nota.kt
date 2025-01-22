fun main() {
    
    print("Insira seu nome: ")
    val nome = readLine()
    print("Insira seu sobrenome: ")
    val sobrenome = readLine()
    println("ola $nome $sobrenome")
    print("Insira sua nota: ")
    val n1 : Int = readLine()?.toIntOrNull() ?: 0
    print("Insira sua nota: ")
    val n2 : Int = readLine()?.toIntOrNull() ?: 0
    print("Insira sua nota: ")
    val n3 : Int = readLine()?.toIntOrNull() ?: 0
    val res = (n1+n2+n3)/3
    
    if(res>=5){
        print("Vai ter vrau")
    }else{
        print("Lascou Gurizada \n")
    }
    
    val op : Int = readLine()?.toIntOrNull()?: 0
    
    
    println("Sua nota $res")
    
    
    
}
