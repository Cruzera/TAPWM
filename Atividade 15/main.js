function abrirJanela(obj) {
    document.getElementById('janela').src = 'assets/janela_aberta.png';
    document.getElementById('status').textContent = 'Janela Aberta';
}

function fecharJanela(obj) {
    document.getElementById('janela').src = 'assets/janela_fechada.png';
    document.getElementById('status').textContent = 'Janela Fechada';
}

function quebrarJanela(obj) {
    document.getElementById('janela').src = 'assets/janela_quebrada.png';
    document.getElementById('status').textContent = 'Janela Quebrada';
}