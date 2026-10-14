let notas = [5, 8, 7, 4, 10, 6]
let soma = 0
let quantidaderepro = 0
let quantidadeaprov = 0

for(let indice = 0; indice < notas.length; indice++) {
    if(notas[indice] >= 7){
        quantidadeaprov ++
        soma = soma + notas[indice]
    }
    else {quantidaderepro ++
         }
}
let media = soma/quantidadeaprov
console.log(`Quantidades de Notas Reprovadas:${quantidaderepro}, média das notas aprovadas: ${media}`)
    
