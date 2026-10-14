let temperaturas = [18, 27, 31, 22, 35, 16, 29, 33]
let quantidade = 0
let soma = 0
let soma2 = 0

for (let indice = 0; indice < temperaturas.length; indice++){
    if (temperaturas[indice] > 25){
        quantidade ++
        soma = soma + temperaturas[indice]
    }
    if (temperaturas[indice] <= 25){
        soma2 = soma2 + temperaturas[indice]
    }
}
let media = soma/quantidade
console.log(`Media da temperaturas maiores que 25: ${media}, quantidade de temperaturas maiores que 25: ${quantidade}, Soma das temperaturas menores e igual a 25: ${soma2}`)
