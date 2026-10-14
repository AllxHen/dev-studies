let numeros = [12, 5, 18, 7, 20, 3, 14, 9]
let quantidadepares = 0
let quantidadeimpares = 0
let soma = 0
let soma2 = 0


for (let indice = 0; indice < numeros.length; indice++) {
    if (numeros[indice] % 2 === 0){
        quantidadepares ++
        soma = soma + numeros[indice]
    }
    else {quantidadeimpares++
          soma2 = soma2 + numeros[indice]
         }
}
let media = soma/quantidadepares
let media2 = soma2/quantidadeimpares
console.log(`Quantidade de numeros pares: ${quantidadepares}, Media dos Pares: ${media}, Quantidade de impares: ${quantidadeimpares}, Media dos numeros impares: ${media2}`)
