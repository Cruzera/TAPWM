function verificarSubconjunto() {
    palavra = [prompt("Digite a primeira palavra:"), prompt("Digite a segunda palavra:")];
    if (!palavra[0] || !palavra[1]) {
      alert("erro");
    }
    if (palavra[0].includes(palavra[1])) {
      alert("é um subconjunto");
    } else {
      alert("não é um subconjunto");
    }
  }

  verificarSubconjunto();