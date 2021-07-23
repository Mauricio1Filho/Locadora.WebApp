$(document).ready(function () {
    $("#btn1").click(function () {
        document.querySelector("#inputEmail")
        document.querySelector("#inputSenha")
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
                if (data) {
                    window.location.href = "http://localhost:5000/Home"
                }
                else {
                    alert("usuario ou senha invalido")
                }
            }
        });
    })
});





