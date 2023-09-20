
var peso = prompt("Informe o seu peso");
var altura = prompt("Informe a sua altura");

var IMC = Math.round(parseFloat(peso) / Math.pow(parseFloat(altura), 2));

var Classificacao;
var Grau;

if (IMC < 18.5) {
    Classificacao = "Magreza";
    Grau = 0;
}
else if (IMC < 24.9) {
    Classificacao = "Normal";
    Grau = 0;
}
else if (IMC < 29.9) {
    Classificacao = "Sobrepeso";
    Grau = 1;
}
else if (IMC < 39.9) {
    Classificacao = "Obesidade";
    Grau = 2;
}
else {
    Classificacao = "Obesidade grave";
    Grau = 3;
}

alert("Seu IMC é " + IMC + "\nSua classificação é " + Classificacao + "\nVocê possui obesidade grau " + Grau);