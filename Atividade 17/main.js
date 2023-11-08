function validarDados() {
    if (document.forms.formulario1.elements[0].value == "" || document.forms.formulario1.elements[0].value.length < 10) {
        alert("Preencha campo NOME corretamente!");
        document.forms.formulario1.elements[0].focus();
        return false;
    }
    if (document.forms.formulario1.elements["idEmail"].value == "" || document.forms.formulario1.elements["idEmail"].value.indexOf('@') == -1 || document.forms.formulario1.elements["idEmail"].value.indexOf('.') == -1) {
        alert("Preencha campo E-MAIL corretamente!");
        document.forms.formulario1.elements.idEmail.focus();
       return false;
    }
    if (document.forms.formulario1.elements.idMensagem.value == "" || document.forms.formulario1.elements.idMensagem.value.length < 50) {
        alert("É necessario preencher o campo COMENTÁRIO com mais de 50 caracteres!");
        document.getElementById("idMensagem").focus();
        return false;
    }
    if (document.getElementById("idSim").checked) {
        alert("Volte sempre a esta página!");
        return false;
    } else if (document.getElementById("idNao").checked) {
        alert("Que bom que você voltou a visitar esta página!");
        return false;
    }
    return true;
}