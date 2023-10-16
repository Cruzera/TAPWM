function somaQuadrado() {
    num = [prompt("Insira o primeiro número:"), prompt("Insira o segundo número:"), prompt("Insira o terceiro número:")];

    soma = parseFloat(num[0]) + parseFloat(num[1]) + parseFloat(num[2]);
    quadrado1 = Math.pow(parseFloat(num[0]), 2);
    quadrado2 = Math.pow(parseFloat(num[1]), 2);

    alert("A soma dos três números é " + soma + "\nO quadrado do primeiro número é " + quadrado1 + "\nO quadrado do segundo número é " + quadrado2);
}

somaQuadrado();