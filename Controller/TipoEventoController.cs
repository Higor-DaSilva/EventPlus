using EventPlus.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using EventoPlus.Interfaces;

namespace EventPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoEventoController : ControllerBase
    {

        private readonly ITipoEventoRepository _tiposEventosRepository;

        public TipoEventoController(ITipoEventoRepository tipoEventoRepository)
        {
            _tiposEventosRepository = tipoEventoRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                List<TipoEvento> tipoEventoListar = _tiposEventosRepository.Listar();
                return Ok(tipoEventoListar);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]

        public IActionResult Post(TipoEvento novoEvento)
        {
            try
            {
                _tiposEventosRepository.Cadastrar(novoEvento);

                return Created();

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("BuscarPorId/{id}")]

        public IActionResult GetById(Guid id)
        {
            try
            {
                TipoEvento EventoBuscado = _tiposEventosRepository.BuscarPorId(id);

                return Ok(EventoBuscado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(Guid id)
        {
            try
            {
                _tiposEventosRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut("{id}")]

        public IActionResult Put(Guid id, TipoEvento tipoEvento)
        {
            try
            {
                _tiposEventosRepository.Atualizar(id, tipoEvento);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

