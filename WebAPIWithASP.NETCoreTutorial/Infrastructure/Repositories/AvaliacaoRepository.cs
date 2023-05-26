using ASP.NETCoreWebAPIwithUnitOfWork.Data;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Repositories;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Infrastructure.Repositories
{
    public class AvaliacaoRepository: IAvaliacaoRepository
    {
        private readonly CatalogoContext _context;

        public AvaliacaoRepository(CatalogoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Avaliacao>> GetAvaliacoes()
        {
            return await _context.Avaliacaos.ToListAsync();
        }

        public async Task<Avaliacao> GetAvaliacaoById(int id)
        {
            return await _context.Avaliacaos.FindAsync(id);
        }

        public async Task AddAvaliacao(Avaliacao avaliacao)
        {
            await _context.Avaliacaos.AddAsync(avaliacao);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAvaliacao(Avaliacao avaliacao)
        {
            _context.Avaliacaos.Update(avaliacao);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAvaliacao(int id)
        {
            var avaliacao = await _context.Avaliacaos.FindAsync(id);
            if (avaliacao != null)
            {
                _context.Avaliacaos.Remove(avaliacao);
                await _context.SaveChangesAsync();
            }
        }
    }
}
