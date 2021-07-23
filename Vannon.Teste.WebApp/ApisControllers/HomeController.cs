using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.ApisControllers
{
    [Route("api/[Controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IReservaService _reservaService;
        private readonly ILocacaoService _locacaoService;
        private readonly IFilmeService _filmeService;

        public HomeController(IReservaService reservaService, ILocacaoService locacaoService, IFilmeService filmeService)
        {
            _reservaService = reservaService;
            _locacaoService = locacaoService;
            _filmeService = filmeService;
        }

        [HttpPost]
        public async Task<IActionResult> ReservaPost([FromBody] long idUsuario, long idReserva)
        {
            try
            {
               await _reservaService.ReservarFilmeAsync(idUsuario, idReserva);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        public async Task<IActionResult> ReservaDelete(long idReserva)
        {
            try
            {
               await _reservaService.RemoverReservaAsync(idReserva);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("locacao")]
        public async Task<IActionResult> LocacaoPost([FromBody] long idFilme ,long idReserva)
        {
            try
            {
                await _locacaoService.CriarReservaFilmeAsync(idFilme , idReserva);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> FilmeGet(long idFilme)
        {
            try
            {
                await _filmeService.BuscarFilmeAsync(idFilme);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
