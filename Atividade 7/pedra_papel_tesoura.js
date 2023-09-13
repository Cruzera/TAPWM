var EscolhaUsuario = prompt("Escreva Pedra, Papel ou Tesoura.");
var EscolhaAdversario = Math.floor((Math.random() * 3) + 1);

if (EscolhaUsuario == "Pedra") {
    EscolhaUsuario = 1;
}
else if (EscolhaUsuario == "Papel") {
    EscolhaUsuario = 2;
}
else if (EscolhaUsuario == "Tesoura") {
    EscolhaUsuario = 3;
}
else {
    alert("Digite certo.");
}

switch (EscolhaAdversario) {
    case 1: {
        if (EscolhaUsuario == 1) {
            alert("O jogo Empatou!\nO adversário também escolheu Pedra.");
        }
        if (EscolhaUsuario == 2) {
            alert("Você venceu!\nO adversário escolheu Pedra.");
        }
        if (EscolhaUsuario == 3) {
            alert("Você perdeu :(\nO adversário escolheu Pedra.");
        }
        break;
    }
    case 2: {
        if (EscolhaUsuario == 1) {
            alert("Você perdeu :(\nO adversário escolheu Papel.");
        }
        if (EscolhaUsuario == 2) {
            alert("O jogo Empatou!\nO adversário também escolheu Papel.");
        }
        if (EscolhaUsuario == 3) {
            alert("Você venceu!\nO adversário escolheu Papel.");
        }
        break;
    }
    case 3: {
        if (EscolhaUsuario == 1) {
            alert("Você venceu!\nO adversário escolheu Tesoura.");
        }
        if (EscolhaUsuario == 2) {
            alert("Você perdeu :(\nO adversário escolheu Tesoura.");
        }
        if (EscolhaUsuario == 3) {
            alert("O jogo Empatou :/\nO adversário também escolheu Tesoura.");
        }
        break;
    }
}