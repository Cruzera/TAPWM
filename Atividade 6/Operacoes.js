function Operacoes() {
    num1 = prompt("Escreva o primeiro número");
    num2 = prompt("Escreva o segundo número");
}

alert(Operacoes());

audi = parseFloat(num1) + parseFloat(num2);
sub = parseFloat(num1) - parseFloat(num2);
multi = parseFloat(num1) * parseFloat(num2);
div = parseFloat(num1) / parseFloat(num2);
resto = parseFloat(num1) % parseFloat(num2);

alert("Adição: " + audi + "\nSubtração: " + sub + "\nMultiplicação: " + multi + "\nDivisão: " + div + "\nResto: " + resto);