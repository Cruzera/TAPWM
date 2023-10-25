function Conta(nomeCorrentista, banco, numeroConta, saldo) {
    this.nomeCorrentista = nomeCorrentista;
    this.banco = banco;
    this.numeroConta = numeroConta;
    this.saldo = saldo;

    this.getNomeCorrentista = function () {
      return this.nomeCorrentista;
    };
    this.setNomeCorrentista = function (nome) {
      this.nomeCorrentista = nome;
    };
    this.getBanco = function () {
      return this.banco;
    };
    this.setBanco = function (novoBanco) {
      this.banco = novoBanco;
    };
    this.getNumeroConta = function () {
      return this.numeroConta;
    };
    this.setNumeroConta = function (novoNumeroConta) {
      this.numeroConta = novoNumeroConta;
    };
    this.getSaldo = function () {
      return this.saldo;
    };
    this.setSaldo = function (novoSaldo) {
      this.saldo = novoSaldo;
    };
}

function ContaCorrenteComSaldoEspecial(nomeCorrentista, banco, numeroConta, saldo, saldoEspecial) {
    Conta.call(this, nomeCorrentista, banco, numeroConta, saldo);
    this.saldoEspecial = saldoEspecial;

    this.getSaldoEspecial = function () {
        return this.saldoEspecial;
    };
    this.setSaldoEspecial = function (novoSaldoEspecial) {
      this.saldoEspecial = novoSaldoEspecial;
    };
}

function ContaPoupancaComJuros(nomeCorrentista, banco, numeroConta, saldo, dataVencimento) {
    Conta.call(this, nomeCorrentista, banco, numeroConta, saldo);
    this.dataVencimento = dataVencimento;

    this.getDataVencimento = function () {
        return this.dataVencimento;
    };
    this.setDataVencimento = function (novaDataVencimento) {
      this.dataVencimento = novaDataVencimento;
    };
  }
  
const nomeCorrentista = prompt("Informe o nome do correntista:");
const banco = prompt("Informe o nome do banco:");
const numeroConta = prompt("Informe o número da conta:");
const saldo = parseFloat(prompt("Informe o saldo da conta:"));

const conta = new Conta(nomeCorrentista, banco, numeroConta, saldo);

alert("Dados da Conta:\n" + "Nome do Correntista: " + conta.getNomeCorrentista() + "\n" + "Banco: " + conta.getBanco() + "\n" + "Número da Conta: " + conta.getNumeroConta() + "\n" + "Saldo: " + conta.getSaldo());

if (confirm("Deseja criar uma Conta Corrente com Saldo Especial?")) {
    const saldoEspecial = parseFloat(prompt("Informe o saldo especial:"));
    const contaCorrenteComSaldoEspecial = new ContaCorrenteComSaldoEspecial(nomeCorrentista, banco, numeroConta, saldo, saldoEspecial);

    alert("Dados da Conta Corrente com Saldo Especial:\n" + "Nome do Correntista: " + contaCorrenteComSaldoEspecial.getNomeCorrentista() + "\n" + "Banco: " + contaCorrenteComSaldoEspecial.getBanco() + "\n" + "Número da Conta: " + contaCorrenteComSaldoEspecial.getNumeroConta() + "\n" + "Saldo: " + contaCorrenteComSaldoEspecial.getSaldo() + "\n" + "Saldo Especial: " + contaCorrenteComSaldoEspecial.getSaldoEspecial());
  }

if (confirm("Deseja criar uma Conta Poupança com Juros?")) {
    const dataVencimento = prompt("Informe a data de vencimento:");
    const contaPoupancaComJuros = new ContaPoupancaComJuros(nomeCorrentista, banco, numeroConta, saldo, dataVencimento);

    alert("Dados da Conta Poupança com Juros:\n" + "Nome do Correntista: " + contaPoupancaComJuros.getNomeCorrentista() + "\n" + "Banco: " + contaPoupancaComJuros.getBanco() + "\n" + "Número da Conta: " + contaPoupancaComJuros.getNumeroConta() + "\n" + "Saldo: " + contaPoupancaComJuros.getSaldo() + "\n" + "Data de Vencimento: " + contaPoupancaComJuros.getDataVencimento());
  }