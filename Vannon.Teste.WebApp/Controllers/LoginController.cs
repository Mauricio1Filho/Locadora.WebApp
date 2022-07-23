using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.DTOs;

namespace Vannon.Teste.WebApp.Controllers
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
                var result = _loginService.LogarAsync(payload.Login, payload.Senha).Result;
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
