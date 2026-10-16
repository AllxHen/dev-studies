let numeros = [4, 7, 10, 3, 8, 5]
let acumuladora = 0

function somaPares(numeros){
    for (let indice = 0; indice < numeros.length; indice++){
        if (numeros[indice] % 2 === 0){
            acumuladora = acumuladora + numeros[indice]
        }
    }
    return acumuladora
}

let resultado = somaPares(numeros)
console.log(resultado)
