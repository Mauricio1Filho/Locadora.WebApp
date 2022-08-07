(function($) {

	"use strict";

	var fullHeight = function() {

		$('.js-fullheight').css('height', $(window).height());
		$(window).resize(function(){
			$('.js-fullheight').css('height', $(window).height());
		});

	};
	fullHeight();

	$(".toggle-password").click(function() {

	  $(this).toggleClass("fa-eye fa-eye-slash");
	  var input = $($(this).attr("toggle"));
	  if (input.attr("type") == "password") {
	    input.attr("type", "text");
	  } else {
	    input.attr("type", "password");
	  }
	});

})(jQuery);

//function mascara(i) {

//	var v = i.value;

//	if (isNaN(v[v.length - 1])) { // impede entrar outro caractere que não seja número
//		i.value = v.substring(0, v.length - 1);
//		return;
//	}

//	i.setAttribute("maxlength", "14");
//	if (v.length == 3 || v.length == 7) i.value += ".";
//	if (v.length == 11) i.value += "-";

//}
