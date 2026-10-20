let notas = [6, 8, 4, 10, 7, 5]

function contarAprovados(notas){
    let quantidade = 0
        for (let indice = 0; indice < notas.length; indice++){
            if (notas[indice] >= 7){
                quantidade ++
            }
        }
    return quantidade
}

let resultado = contarAprovados(notas);
console.log(`Quantidade de notas aprovadas: ${resultado}`);
