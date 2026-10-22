let jogador = {
    nome: "Goku",
    vida: 100
}

function receberDano(jogador, dano){
    jogador.vida = jogador.vida - dano
    console.log(jogador)
}

function curarVida(jogador,recuperar){
    jogador.vida = jogador.vida + recuperar
    console.log(jogador)
}

receberDano(jogador, 50)
curarVida(jogador, 30)

