function Media() {
    nome = prompt("Nome");
    nota1 = prompt("Primeira nota");
    nota2 = prompt("Segunda nota");
    nota3 = prompt("Terceira nota");
}

alert(Media());

media = (parseFloat(nota1) + parseFloat(nota2) + parseFloat(nota3))/3;

alert("A média do aluno " + nome + " é " + media);