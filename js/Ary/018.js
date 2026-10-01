let produtos = [50, 120, 80, 200, 30, 150]
let quantidade = 0
let soma = 0

for (let indice = 0; indice < produtos.length; indice++){
    if (produtos[indice] >= 100){
        quantidade++
        soma = soma + produtos[indice]
    }
}
console.log(`Soma total dos produtos igual e acima de 100: ${soma} - Quantidade de produtos igual e acima de 100: ${quantidade}`)
