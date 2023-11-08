function mostrarConfirmacao() {
    const selectElement = document.getElementById("cursoSelect");
    const selectedCourse = selectElement.value;

    if (selectedCourse) {
        const confirmDialog = confirm("Deseja abrir o curso de " + selectElement.options[selectElement.selectedIndex].text + "?");

        if (confirmDialog) {
        abrirJanelaCurso(selectedCourse);
        }
    }
    }

    function abrirJanelaCurso(curso) {
    let url = "";
    let nomeCurso = "";
    let dimensoes = "width=600,height=300";

    if (curso === "ads") {
        url = "ads.html";
        nomeCurso = "Análise e Desenvolvimento de Sistemas";
    } else if (curso === "logistica") {
        url = "log.html";
        nomeCurso = "Logística";
    }

    const novaJanela = window.open(url, nomeCurso, dimensoes);
}