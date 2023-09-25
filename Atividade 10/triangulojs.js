var m1 = parseFloat(prompt("Informe a primeira medida"))
var m2 = parseFloat(prompt("Informe a segunda medida"))
var m3 = parseFloat(prompt("Informe a terceira medida"))

if (Number.isNaN(m1, m2, m3) || m1 <= 0 || m2 <= 0 || m3 <= 0) {
    alert("Digite somente números acima de 0.");
}
else if (m2 - m3 < m1 < m2 + m3 && m1 - m3 < m2 < m1 + m3 && m1 - m2 < m3 < m1 + m2) {
    if (m1 == m2 && m1 == m3) {
        alert("Com as medidas dadas, é possível fazer um triângulo Equilátero.")
    }
    else if (m1 == m2 || m2 == m3 || m3 == m1) {
        alert("Com as medidas dadas, é possível fazer um triângulo Isósceles.")
    }
    else {
        alert("Com as medidas dadas, é possível fazer um triângulo Escaleno.")
    }
}
else {
    alert("Com as medidas dadas, não é possível fazer um triângulo.");
}