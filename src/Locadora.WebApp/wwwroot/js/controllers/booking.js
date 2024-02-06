$(document).ready(function () {
    $("#btnLocar").click(function () {
        var inputcpf = $("#inputCpf").val();
        var idFilme = $("#inputIdFilme").val();
        console.log(inputcpf, idFilme)
        const url = "/Booking/CriarLocacaoFilme"
        $.ajax({
            type: "POST",
            dataType: 'json',
            url: url,
            data: JSON.stringify({
                cpf: inputcpf,
                idFilme: parseInt(idFilme)
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                if (data) {
                    window.location.href = "/success";
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
                    $("#inputNome").val(data.nome)
                    $("#inputContatoEmail").val(data.contato.email);
                    $("#inputContatoCelular").val(data.contato.celular);
                    $("#inputEndereco").val(data.endereco.endereco);
                    $("#inputEnderecoNumero").val(data.endereco.numero);
                    $("#inputEnderecoBairro").val(data.endereco.bairro);
                    $("#inputEnderecoCEP").val(data.endereco.cep);
                    $("#inputEnderecoCidade").val(data.endereco.cidade);
                }
                else {
                    alert("Campos nao preenchidos corretamente")
                }
            }
        });
    });
});