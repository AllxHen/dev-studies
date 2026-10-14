let numeros = [4, 12, 7, 18, 20, 3, 14, 9, 22, 11]
let quantidadepar = 0
let quantidadeimpar = 0
let soma = 0


for (let indice = 0; indice < numeros.length; indice++) {
    if (numeros[indice] % 2 === 0 && numeros[indice] > 10){
        quantidadepar++
        soma = soma + numeros[indice]
    }
    if (numeros[indice] % 2 === 1){
        quantidadeimpar ++
    }
}
console.log(`quantidade de numeros pares maiores que 10:${quantidadepar}, soma dos numeros pares maiores de 10:${soma}, quantidade de numeros impares menores que 10:${quantidadeimpar}`)
