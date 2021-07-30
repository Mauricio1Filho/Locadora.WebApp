$(document).ready(function () {
    $("#btnCadastrar").click(function () {
        document.querySelector("#inputNome");
        document.querySelector("#inputCpf");
        var inputNome = $("#inputNome").val();
        var inputCpf = $("#inputCpf").val();
        console.log(inputNome, inputCpf)
        $.ajax({
            type: "POST",
            url: "api/Clientes",
            data: JSON.stringify({
                nome: inputNome,
                cpf: inputCpf,
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                if (data) {
                    alert("Cliente cadastrado com sucesso com sucesso");
                }
                else {
                    alert("Campos nao preenchidos corretamente")
                }
            }
        });
    })
});

$(document).ready(function () {
    $("#btnBuscar").click(function () {
        var inputIdCliente = $("#inputIdCliente").val();
        console.log(inputIdCliente)
        const url = "api/Clientes"
        $.ajax({
            type: "GET",
            url: url + "/" + inputIdCliente,
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                if (data) {
                    $("#inputNome").val(data.nome);
                    $("#inputCpf").val(data.cpf);
                    $("#inputReserva").val(data.reserva);
                }
                else {
                    alert("Campos nao preenchidos corretamente")
                }
            }
        });
    });
});
