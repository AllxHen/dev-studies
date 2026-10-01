let notas = [5, 8, 7, 4, 10, 6]
let soma = 0
let quantidade = 0

for (let indice = 0; indice < notas.length; indice ++){
    if (notas[indice] >= 7){
        quantidade++
        soma = soma + notas[indice]
    }
}
let media = soma/quantidade
console.log(media)
