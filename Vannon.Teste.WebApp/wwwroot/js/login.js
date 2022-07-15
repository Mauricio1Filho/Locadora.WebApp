$(document).ready(function () {
    $("#btnEntrar").click(function () {
        var inputEmail = $("#inputEmail").val();
        var inputSenha = $("#inputSenha").val();
        $.ajax({
            type: "POST",
            url: "api/Login",
            data: JSON.stringify({
                login: inputEmail,
                senha: inputSenha
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                window.location.href = "/Home";
            },
            error: function (data) {
                alert("Credenciais invalidas");
            }
        });
    })
});





