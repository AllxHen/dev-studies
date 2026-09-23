for (let produto = 1; produto <= 20; produto++){
    let preco = produto*25
    if (preco >= 250){
        console.log(`Produto ${produto} - R$${preco} - Desconto`)
    }
    else {console.log(`Produto ${produto} - R$${preco} - Sem desconto`)

}

}
