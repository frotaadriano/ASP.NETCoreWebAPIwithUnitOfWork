using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NETCoreWebAPIwithUnitOfWork.Data;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Services;

namespace ASP.NETCoreWebAPIwithUnitOfWork.ASP.NETCoreWebAPIwithUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private readonly CatalogoContext _context;
        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoController(CatalogoContext context, IAvaliacaoService avaliacaoService)
        {
            _context = context;
            _avaliacaoService = avaliacaoService;
        }

        // GET: api/Avaliacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avaliacao>>> GetAvaliacaos()
        {
            if (_context.Avaliacaos == null)
            {
                return NotFound();
            }  
            var avaliacoes = await _avaliacaoService.GetAvaliacaos();
            return Ok(avaliacoes); 
        }

        // GET: api/Avaliacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Avaliacao>> GetAvaliacaoById(int id)
        {
            var avaliacao = await _avaliacaoService.GetAvaliacaoById(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            return Ok(avaliacao);
        }

        // PUT: api/Avaliacao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvaliacao(int id, Avaliacao avaliacao)
        {
            if (id != avaliacao.AvaliacaoId)
            {
                return BadRequest();
            }
            await _avaliacaoService.UpdateAvaliacao(avaliacao);
            return NoContent();
        }

        // POST: api/Avaliacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Avaliacao>> PostAvaliacao(Avaliacao avaliacao)
        {
            await _avaliacaoService.AddAvaliacao(avaliacao);
            return CreatedAtAction(nameof(GetAvaliacaoById), new { id = avaliacao.AvaliacaoId }, avaliacao);
        }

        // DELETE: api/Avaliacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvaliacao(int id)
        {
            await _avaliacaoService.DeleteAvaliacao(id);
            return NoContent();
        }

        private bool AvaliacaoExists(int id)
        {
            return (_context.Avaliacaos?.Any(e => e.AvaliacaoId == id)).GetValueOrDefault();
        }
    }
}
