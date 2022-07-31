using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.DTOs;
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
        public IActionResult Logar([FromBody]LoginDTO payload)
        {
            try
            {
                var result = _loginService.Logar(payload.Login, payload.Senha);
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
