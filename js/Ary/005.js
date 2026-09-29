let frutas = ["maçã", "banana", "laranja", "pera"]

for (let indice = 0; indice < frutas.length; indice++){
    console.log(frutas[indice])
    frutas[indice] = "Esgotado"
    console.log(frutas[indice])
}
