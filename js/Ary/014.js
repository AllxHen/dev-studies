let numeros = [4, 11, 8, 15, 20, 7, 12, 3]
let quantidade = 0

for (let indice = 0; indice < numeros.length; indice++){
    if (numeros[indice] % 2 === 0){
        quantidade++
        console.log(`${numeros[indice]} - quantidade de Pares: ${quantidade}`)
    }
}
