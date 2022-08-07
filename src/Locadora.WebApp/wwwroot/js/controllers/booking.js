$(document).ready(function () {
    $("#btnLocar").click(function () {
        var inputIdCliente = $("#inputIdCliente").val();
        var idFilme = $("#idFilme").val();
        const url = "/Booking/CriarLocacaoFilme"
        $.ajax({
            type: "POST",
            url: url,
            data: JSON.stringify({
                idCliente: inputIdCliente,                
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                if (data) {
                    alert("Locacao feita com sucesso")
                }
            }
        });
    })
});

$(document).ready(function () {
    $("#btnSearch").click(function () {
        var inputCpf = $("#inputCpf").val();
        const url = "/Booking/BuscarClientCpf/" + inputCpf
        $.ajax({
            type: "GET",
            dataType: 'json',
            url: url,
            data: {
                cpf: inputCpf
            },
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                if (data) {
                    $("#inputNome").html(data.nome);
                    $("#inputContatoEmail").html(data.contato.email);
                    $("#inputContatoCelular").html(data.contato.celular);
                    $("#inputEndereco").html(data.endereco.endereco);
                    $("#inputEnderecoNumero").html(data.endereco.numero);
                    $("#inputEnderecoBairro").html(data.endereco.bairro);
                    $("#inputEnderecoCEP").html(data.endereco.cep);
                    $("#inputEnderecoCidade").html(data.endereco.cidade);
                }
                else {
                    alert("Campos nao preenchidos corretamente")
                }
            }
        });
    });
});