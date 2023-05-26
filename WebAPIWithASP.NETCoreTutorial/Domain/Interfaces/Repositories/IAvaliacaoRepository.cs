using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Repositories
{
    public interface IAvaliacaoRepository
    { 
        Task<IEnumerable<Avaliacao>> GetAvaliacoes();
        Task<Avaliacao> GetAvaliacaoById(int id);
        Task AddAvaliacao(Avaliacao avaliacao);
        Task UpdateAvaliacao(Avaliacao avaliacao);
        Task DeleteAvaliacao(int id); 
    }
}
