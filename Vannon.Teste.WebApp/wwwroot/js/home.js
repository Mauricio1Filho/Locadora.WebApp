$(document).ready(function () {
    $("#btn2").click(function () {
        var inputIdCliente = $("#inputIdCliente").val();
        const url = "api/Home/locacao"
        console.log(inputIdCliente)
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
                else {
                    alert("Campos nao preenchidos corretamente")
                }
            }
        });
    })
});

