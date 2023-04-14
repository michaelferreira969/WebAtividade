class Usuario {
    constructor(newUser) {
        this.nome = newUser.nome;
        this.username = newUser.username;
        this.email = newUser.email;
        this.senha = newUser.senha;
        this.cpf = newUser.cpf;
        this.dataNascimento = newUser.dataNascimento;
        this.numCelular = newUser.numCelular;
        this.endereco = newUser.endereco;
    }
}

class UsuarioController {
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

        $(".filtrarUsuario").on("click", function () {
            prompt("Digite um nome:")
        });

        $(document).on("click", "#addUsuario", function () {
            let data = {
                nome: $("#iNome").val(),
                username: $("#iUsername").val(),
                email: $("#iEmail").val(),
                senha: $("#iSenha").val(),
                cpf: $("#iCPF").val(),
                dataNascimento: $("#iDataNascimento").val(),
                numCelular: $("#iNumCelular").val(),
                endereco: $("#iEndereco").val()
            }

            _.cadastrarUsuario(data);
        });
    }

    montarGrid() {
        let _ = this;

        _.buscarUsuariosAsync();
    }

    cadastrarUsuario(newUser) {
        let _ = this;

        //Cria um novo usuário baseado no objeto Usuario
        let data = new Usuario(newUser);

        _.cadastrarUsuarioAsync(data);
    }

    //Preencher tabela de lojas
    preencherTableLojas(listLojas) {
        let _ = this,
            linha = "",
            loja,
            contatoFormated;

        for (let i = 0; i < listLojas.length; i++) {
            loja = listLojas[i];

            contatoFormated = loja.contato.toString();
            contatoFormated = contatoFormated.replace(/(\d{2})(\d{5})(\d{4})/, "($1) $2-$3");

            linha += '<tr>';
            linha += '<td class="overflow text-left">' + loja.nome + '</td>';
            linha += '<td class="overflow text-left" title="' + loja.endereco + '">' + loja.endereco + '</td>';
            linha += '<td class="overflow">' + contatoFormated + '</td>';
            linha += '</tr>';

            $("#tableVerLojas tbody").prepend(linha);
            linha = "";
        }
    }

    //Requisões para a Controller

    buscarUsuariosAsync() {
        $.ajax({
            url: '/Controller/GetDados',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                // Insere os dados recebidos no elemento HTML
                $('#dados').text('Nome: ' + data.nome + ', Idade: ' + data.idade);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });

    }

    cadastrarUsuarioAsync(data) {
        $.ajax({ method: "POST", url: "CadastrarUsuario", data: data });
    }

} (function () { new UsuarioController() }());