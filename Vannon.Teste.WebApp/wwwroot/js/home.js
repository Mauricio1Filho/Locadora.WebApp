$(document).ready(function () {
    $("#btnLocar").click(function () {
        var inputIdCliente = $("#inputIdCliente").val();
        var idFilme = $("#idFilme").val();
        const url = "api/Home/locacaoPost"
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
        const url = "api/Home/cpf/" + inputCpf
        $.ajax({
            type: "GET",
            url: url,
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                if (data) {
                    $("#inputNome").html(data.nome);
                    console.log(data.nome)
                    $("#inputIdCliente").html(data.idCliente);                    
                }
                else {
                    alert("Campos nao preenchidos corretamente")
                }
            }
        });
    });
});


