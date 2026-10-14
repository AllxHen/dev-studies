let vendas = [120, 45, 200, 80, 150, 30, 250, 90]
let quantidade = 0
let soma = 0
let soma1 = 0

for (let indice = 0; indice < vendas.length; indice++){
    if (vendas[indice] >= 100){
        quantidade ++
        soma = soma + vendas[indice]
    }
    if (vendas[indice] < 100){
        soma1 = soma1 + vendas[indice]
    }
}
let media = soma/quantidade
console.log(`Quantidade de vendas maiores ou iguais a R$ 100: ${quantidade}, Media de vendas maiores que 100:${media}, Soma de vendas menores que 100: ${soma1}`)
