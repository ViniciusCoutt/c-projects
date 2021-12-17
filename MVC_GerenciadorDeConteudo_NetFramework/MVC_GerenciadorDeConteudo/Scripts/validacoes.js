const validarExclusao = function (id, evento) {
    if (confirm("Excluir dados?")) {
        return true;
    } else {
        evento.preventDefault();
        return false;
    }
}