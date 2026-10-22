let jogador = {
    nome: "Goku",
    vida: 100
}


function receberDano(jogador, dano){
    jogador.vida = jogador.vida - dano
    if (jogador.vida <= 0){
        jogador.vida = 0
    }
    console.log(jogador)
}

function curarVida(jogador,recuperar){
    jogador.vida = jogador.vida + recuperar
    if (jogador.vida >= 100){
        jogador.vida = 100
    }
    console.log(jogador)
}

receberDano(jogador,120)
curarVida(jogador,200)
