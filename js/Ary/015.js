let notas = [4, 7, 8, 5, 10, 6, 9]
let quantidade = 0

for (let indice = 0; indice < notas.length; indice ++){
    if (notas[indice] >= 7){
        quantidade++
    }
}
console.log(quantidade)
