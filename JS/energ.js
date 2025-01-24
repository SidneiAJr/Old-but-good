let m = prompt("Insira a massa do objeto")
let c = 300000
let v = prompt("Insira a Velocidade que deseja da nave")

if(v>= c){
    let n = 3;
    let energia = m*c**2*(v/c)**n
     console.log(`energia necessaria expondenciada${energia.toExponential(2)} Joules`)
}else{
    let energia = (m * c ** 2) / Math.sqrt(1 - (v ** 2) / (c ** 2));
    console.log(`energia necessaria expondenciada${energia.toExponential(2)} Joules`)
}
