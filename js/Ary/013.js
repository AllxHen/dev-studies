let numeros = [4, 11, 8, 15, 20, 7, 12, 3]

for (let indice = 0; indice < numeros.length; indice++){
    if (numeros[indice] < 15 && numeros[indice] % 2 === 0){
        console.log(numeros[indice])
    }
}
