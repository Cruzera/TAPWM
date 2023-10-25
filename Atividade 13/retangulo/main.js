function Retangulo(base, altura) {
    this.base = base;
    this.altura = altura;

    this.calcularArea = function() {
        return this.base * this.altura;
    };
}
const base = parseFloat(prompt("Insira a base do retângulo:"));
const altura = parseFloat(prompt("Insira a altura do retângulo:"));
const meuRetangulo = new Retangulo(base, altura);
const area = meuRetangulo.calcularArea();

alert("A área do retângulo é " + area);