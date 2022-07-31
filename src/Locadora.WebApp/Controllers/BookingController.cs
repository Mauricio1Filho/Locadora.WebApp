﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;

namespace Locadora.WebApp.Controllers
{
    public class BookingController : Controller
    {
        #region Views
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Injections
        private readonly ILocacaoService _locacaoService;
        private readonly IFilmeService _filmeService;
        private readonly IClienteService _clienteService;

        public BookingController( ILocacaoService locacaoService, IFilmeService filmeService, IClienteService clienteService)
        {
            _locacaoService = locacaoService;
            _filmeService = filmeService;
            _clienteService = clienteService;
        }
        #endregion

        #region Endpoints
        [HttpPost("locacao")]
        public IActionResult CriarLocacaoFilme([FromBody] int idCliente)
        {
            try
            {
                var result = _locacaoService.CriarLocacaoFilme(idCliente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public IActionResult BuscarFilme(long idFilme)
        {
            try
            {
                var result = _filmeService.BuscarFilme(idFilme);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("cpf/{cpf}")]
        public IActionResult BuscarClientCpf(string cpf)
        {
            try
            {
                var result = _clienteService.BuscarClientCpf(cpf);
                if (result != null)
                    return Ok(result);
                return BadRequest("CPF não encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
