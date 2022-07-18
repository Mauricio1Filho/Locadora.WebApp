$(document).ready(function () {
    $("#btnCadastrar").click(function () {
        var inputNome = $("#inputNome").val();
        var inputCpf = $("#inputCpf").val();
        $.ajax({
            type: "POST",
            url: "api/Client",
            data: JSON.stringify({
                nome: inputNome,
                cpf: inputCpf
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                alert(data)
                
            }
        });
    })
});
