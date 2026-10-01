let numeros = [3, 8, 12, 5, 20, 7, 10]

for(let indice = 0; indice < numeros.length; indice++){
    if (numeros[indice] > 10 && numeros[indice] % 2 === 0){
        console.log(numeros[indice])
    }
}
