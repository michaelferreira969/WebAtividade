$(document).on("click", "#btnAddAcervo", function () {
    $("#modalCadastroAcervo").show();
})



/*$(document).ready(function () {
    $("#botao-ajax").click(function () {
        $.ajax({
            url: "/Controller/AcaoAjax",
            data: { parametro1: valor1, parametro2: valor2 },
            type: "POST",
            success: function (result) {
                // Tratar a resposta do Ajax
            },
            error: function (xhr, status, error) {
                // Tratar o erro do Ajax
            }
        });
    });
});*/

$(".filtrarUsuario").on("click", function () {
    prompt("Digite um nome:")
});

