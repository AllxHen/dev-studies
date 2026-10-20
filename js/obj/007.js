let jogador = {
    nome: "Goku",
    vida: 100
}

let dano = 30

function receberDano(jogador, dano){
    jogador.vida = jogador.vida - dano
    console.log(jogador)
}

receberDano(jogador,dano)
