let numeros = [12, 5, 18, 7, 20, 3, 14, 9, 22, 11]
let quantidade = 0
let quantidade2 = 0
let soma = 0
let soma2 = 0

for (let indice = 0; indice < numeros.length; indice++) {
    if (numeros[indice] > 10){
        quantidade ++
        soma = soma + numeros[indice]
    }
    else {quantidade2 ++
          soma2 = soma2 + numeros[indice]
    }
}
let media = soma/quantidade
console.log(`Quantidade maior que 10: ${quantidade}, media dos numeros maiores de 10: ${media}, quantidade de numeros menores e igual a 10: ${quantidade2}, soma dos numeros menores e igual a 10: ${soma2}`)
