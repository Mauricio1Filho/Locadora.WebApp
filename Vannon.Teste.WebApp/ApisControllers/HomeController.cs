using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;

namespace Vannon.Teste.WebApp.ApisControllers
{
    [Route("api/[Controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IReservaService _reservaService;
        private readonly ILocacaoService _locacaoService;
        private readonly IFilmeService _filmeService;
        private readonly IClienteService _clienteService;

        public HomeController(IReservaService reservaService, ILocacaoService locacaoService, IFilmeService filmeService, IClienteService clienteService)
        {
            _reservaService = reservaService;
            _locacaoService = locacaoService;
            _filmeService = filmeService;
            _clienteService = clienteService;
        }

        [HttpPost("reservaPost")]
        public async Task<IActionResult> ReservaPost([FromBody] long idFilme, long idLocacao)
        {
            try
            {
               await _reservaService.ReservarFilmeAsync(idFilme, idLocacao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        public async Task<IActionResult> ReservaDelete(long idFilme, long idLocacao)
        {
            try
            {
               await _reservaService.RemoverReservaAsync(idFilme , idLocacao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("locacaoPost")]
        public async Task<IActionResult> LocacaoPost([FromBody] long idCliente)
        {
            try
            {
               var result =  await _locacaoService.CriarLocacaoFilmeAsync(idCliente);
                return Ok(result);
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

        [HttpGet("cpf/{cpf}")]
        public async Task<IActionResult> BuscarClientCpfAsync(string cpf)
        {
            try
            {
                var result = await _clienteService.BuscarClientCpfAsync(cpf);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
