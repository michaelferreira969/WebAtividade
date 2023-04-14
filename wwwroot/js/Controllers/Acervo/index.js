class AcervosController {
    constructor() {
        this.init();
    }

    init() {
        let _ = this;

        //Máscaras dos campos
        _.mask();

        //Eventos jQuery
        _.events();
    }

    mask() {
        //$('#iEmail').mask('(00) 00000-0000');
    }

    events() {
        let _ = this;

        /*        $(document).ready(function () {
                    $("#table-acervos").dataTable({
                        "language": {
                            "lengthMenu": "Display _MENU_ records per page",
                            "zeroRecords": "Nothing found - sorry",
                            "info": "Showing page _PAGE_ of _PAGES_",
                            "infoEmpty": "No records available",
                            "infoFiltered": "(filtered from _MAX_ total records)"
                        }
                    });
                });*/

        $(".filtrarAcervo").on("click", function () {
            prompt("Digite um nome:")
        });

        $(document).on("click", "#cadastrar-acervo", function () {
            let data = {
                isbn: parseInt($("#iISBN").val()),
                titulo: $("#iTitulo").val(),
                autor: $("#iAutor").val(),
                anoPublicacao: parseInt($("#iAnoPublicacao").val()),
                numPag: parseInt($("#iNumPag").val()),
                numCap: parseInt($("#iNumCap").val()),
                tipo: parseInt($("#iTipo").val()),
                numExemplares: parseInt($("#iNumExemplares").val()),
            }

            if (data.isbn == '' || data.titulo == '' || data.numPag == '' || data.numCap == '' || data.numExemplares == '')
                return;

            _.cadastrarAcervo(data);
        });

        $(document).on("click", "#limpar", function () {
            _.limparCampos();
        });

        $(document).on("click", "#excluir-acervo", function () {
            console.log($(this).data("id"))
            _.deleteAcervo($(this).data("id"));

            _.searchAcervos();
        });

        $(document).on("click", "#excluir-acervos", function () {
            _.deleteAllAcervos();

            let $tb = $("#table-acervos tbody");
            $("#table-acervos tbody").remove();
        });

    }

    limparCampos() {
        $("#iISBN").val('');
        $("#iTitulo").val('');
        $("#iAutor").val('');
        $("#iAnoPublicacao").val('');
        $("#iNumPag").val('');
        $("#iNumCap").val('');
        $("#iTipo").val('');
        $("#iNumExemplares").val('');
    }

    montarGrid(listAcervos) {
        let _ = this,
            acervo,
            $tb,
            i,
            linha;

        $tb = $("#table-acervos tbody");

        for (i = 0; i < listAcervos.length; i++) {
            acervo = listAcervos[i];

            linha += '<tr>';
            linha += '<td>' + acervo.idAcervo + '</td>'
            linha += '<td>' + acervo.isbn + '</td>';
            linha += '<td>' + acervo.titulo + '</td>';
            linha += '<td>' + acervo.autor + '</td>';
            linha += '<td>' + acervo.anoPublicacao + '</td>';
            linha += '<td>' + acervo.numPag + '</td>';
            linha += '<td>' + acervo.numCap + '</td>';
            linha += '<td>' + acervo.status + '</td>';
            linha += '<td>' + acervo.tipoAcervo + '</td>';
            linha += '<td><button type="button" class="btn btn-danger btn-sm" id="excluir-acervo" data-id="' + acervo.idAcervo +'"><i class="fa-solid fa-trash"></i> <button type="button" class="btn btn-primary btn-sm ml-1" id="editar-acervo"><i class="fa-solid fa-square-pen"></i></td>';
            linha += '</tr>';

            $tb.prepend(linha);
            linha = "";
        }

        _.limparCampos()
    }

    //Requisões para a Controller

    cadastrarAcervo(data) {
        let _ = this;

        $.ajax({
            url: '/Acervo/CadastrarAcervo',
            type: 'post',
            data: data,
            success: function (data) {
                console.log(data);
                _.searchAcervos();
            },
            error: function (xhr, status, error) {
                console.log("Erro na execução!");
            }
        });
    }

    searchAcervos() {
        let _ = this;

        $.ajax({
            url: '/Acervo/SearchAcervos',
            type: 'get',
            success: function (data) {
                console.log("Sucesso!");
                _.montarGrid(data);
            },
            error: function (xhr, status, error) {
                console.log("Erro na execução!");
            }
        });
    }

    editAcervo(data) {
        let _ = this;

        $.ajax({
            url: '/Acervo/EditAcervo',
            type: 'post',
            data: data,
            success: function (data) {
                console.log(data);
            },
            error: function (xhr, status, error) {
                console.log("Erro na execução!");
            }
        });
    }

    deleteAcervo(data) {
        let _ = this;

        $.ajax({
            url: '/Acervo/DeleteAcervo',
            type: 'post',
            data: data,
            success: function (data) {
                console.log(data);
            },
            error: function (xhr, status, error) {
                console.log("Erro na execução!");
            }
        });
    }

    deleteAllAcervos() {
        let _ = this;

        $.ajax({
            url: '/Acervo/DeleteAllAcervo',
            type: 'post',
            success: function (data) {
                console.log(data);
            },
            error: function (xhr, status, error) {
                console.log("Erro na execução!");
            }
        });
    }

} (function () { new AcervosController() }());