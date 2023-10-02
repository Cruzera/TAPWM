function MaiorNum() {
    var numeros = [prompt("Digite o primeiro número:"), prompt("Digite o segundo número:"), prompt("Digite o terceiro número:"), prompt("Digite o quarto número:")];
    alert(Math.max.apply(null, numeros));
}
MaiorNum();


function OrdemNum() {
    var numeros = [prompt("Digite o primeiro número:"), prompt("Digite o segundo número:"), prompt("Digite o terceiro número:"), prompt("Digite o quarto número:")];
    alert(numeros.sort(function(a, b){return a-b}));
}
OrdemNum();