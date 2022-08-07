using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Locadora.WebApp.Controllers
{
    public class LoginController : Controller
    {
        #region Views
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Injections
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        #endregion

        #region Endpoints
        [HttpPost]
        public IActionResult Logar([FromBody]LoginViewModel payload)
        {
            try
            {
                var result = _loginService.Logar(payload.login, payload.senha);
                if (result != null)
                {
                    return Ok();
                }
                return BadRequest("");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
