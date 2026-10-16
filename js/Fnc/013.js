let numeros = [12, 5, 18, 7, 20, 3, 14, 9]

function somarMaioresQueDez(numeros){
    let acumulador = 0
    for (let indice = 0; indice < numeros.length; indice++){
        if (numeros[indice] > 10){
            acumulador = acumulador + numeros[indice]
        }
    }
    return acumulador
}

let resultado = somarMaioresQueDez(numeros)
console.log(resultado)
