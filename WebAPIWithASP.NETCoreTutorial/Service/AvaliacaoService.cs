using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Repositories;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Interfaces.Services;
using ASP.NETCoreWebAPIwithUnitOfWork.Domain.Models;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Service
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository; 
        }

        public Task AddAvaliacao(Avaliacao avaliacao)
        {
            return _avaliacaoRepository.AddAvaliacao(avaliacao);
        }

        public Task DeleteAvaliacao(int id)
        {
            return _avaliacaoRepository.DeleteAvaliacao(id);
        }

        public Task<Avaliacao> GetAvaliacaoById(int id)
        {
            return _avaliacaoRepository.GetAvaliacaoById(id);
        }

        public Task<IEnumerable<Avaliacao>> GetAvaliacaos()
        {
             return _avaliacaoRepository.GetAvaliacoes();
        }

        public Task UpdateAvaliacao(Avaliacao avaliacao)
        {
            return _avaliacaoRepository.UpdateAvaliacao(avaliacao);
        }
    }
}
