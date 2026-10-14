let notas = [4, 8, 6, 10, 7, 3, 9, 5]
let quantidade = 0
let soma = 0
let soma2 = 0

for (let indice = 0; indice < notas.length; indice++){
    if (notas[indice] >= 7){
        quantidade++
        soma = soma + notas[indice]
    }
    else {soma2 = soma2 + notas[indice]}
}
let media = soma/quantidade
console.log(`Quantidade de alunos aprovados com notas maiores ou iguais a 7: ${quantidade} ,Soma das notas reprovadas menores que 7: ${soma2}, Média das notas aprovadas: ${media}`)
