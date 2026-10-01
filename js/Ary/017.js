let notas = [5, 8, 7, 4, 10, 6]
let soma = 0
let quantidade = 0

for(let indice = 0; indice < notas.length; indice++){
    if(notas[indice] >= 7){
        soma = soma + notas[indice]
        quantidade++
    }
}
console.log(`Quantidade de notas igual e acima de 7: ${quantidade} - Soma das Notas acima de 7: ${soma}`)
