using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NETCoreWebAPIwithUnitOfWork.Data;
using ASP.NETCoreWebAPIwithUnitOfWork.Models;

namespace ASP.NETCoreWebAPIwithUnitOfWork.ASP.NETCoreWebAPIwithUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private readonly CatalogoContext _context;

        public AvaliacaoController(CatalogoContext context)
        {
            _context = context;
        }

        // GET: api/Avaliacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avaliacao>>> GetAvaliacaos()
        {
          if (_context.Avaliacaos == null)
          {
              return NotFound();
          }
            return await _context.Avaliacaos.ToListAsync();
        }

        // GET: api/Avaliacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Avaliacao>> GetAvaliacao(int id)
        {
          if (_context.Avaliacaos == null)
          {
              return NotFound();
          }
            var avaliacao = await _context.Avaliacaos.FindAsync(id);

            if (avaliacao == null)
            {
                return NotFound();
            }

            return avaliacao;
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

            _context.Entry(avaliacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvaliacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Avaliacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Avaliacao>> PostAvaliacao(Avaliacao avaliacao)
        {
          if (_context.Avaliacaos == null)
          {
              return Problem("Entity set 'CatalogoContext.Avaliacaos'  is null.");
          }
            _context.Avaliacaos.Add(avaliacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAvaliacao", new { id = avaliacao.AvaliacaoId }, avaliacao);
        }

        // DELETE: api/Avaliacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvaliacao(int id)
        {
            if (_context.Avaliacaos == null)
            {
                return NotFound();
            }
            var avaliacao = await _context.Avaliacaos.FindAsync(id);
            if (avaliacao == null)
            {
                return NotFound();
            }

            _context.Avaliacaos.Remove(avaliacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AvaliacaoExists(int id)
        {
            return (_context.Avaliacaos?.Any(e => e.AvaliacaoId == id)).GetValueOrDefault();
        }
    }
}
