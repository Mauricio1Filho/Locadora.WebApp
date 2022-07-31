$(document).ready(function () {
    $("#btnCadastrar").click(function () {
        var inputNome = $("#inputNome").val();
        var inputCpf = $("#inputCpf").val();
        var inputEmail = $("#inputEmail").val();
        var idDataNasc = $("#idDataNasc").val();
        var inputTel = $("#inputTel").val();
        var idSexo = $("#idSexo").val();
        var inputEndereco = $("#inputEndereco").val();
        var inputNumCasa = $("#inputNumCasa").val();
        var inputBairro = $("#inputBairro").val();
        var inputCEP = $("#inputCEP").val();
        var inputCidade = $("#inputCidade").val();
        var inputEstado = $("#inputEstado").val();
        $.ajax({
            type: "POST",
            url: "client/RegisterClient",
            data: JSON.stringify({
                nome: inputNome,
                cpf: inputCpf,
                email: inputEmail,
                dataNascimento: idDataNasc,
                celular: inputTel,
                sexo: idSexo,
                endereco: inputEndereco,
                numero: parseInt(inputNumCasa),
                bairro: inputBairro,
                cep: inputCEP,
                cidade: inputCidade,
                estado: inputEstado
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                alert("Cliente cadastrado com sucesso!")
            },
            error: function (data) {
                alert("");
            }
        });
    })
});