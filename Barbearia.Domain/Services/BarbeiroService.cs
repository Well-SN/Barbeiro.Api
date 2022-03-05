
using Barbearia.Data.Interfaces;
using Barbearia.Domain.Interfaces;
using Barbearia.Shareable.Requests;
using OperationResult;

namespace Barbearia.Domain.Services;
public class BarbeiroService : IBarbeiroService {
    private readonly IBarbeiroRepository _barbeiroRepository;

    public BarbeiroService(IBarbeiroRepository barbeiroRepository) {
        _barbeiroRepository = barbeiroRepository;
    }
    public Task<Result> CriarBarbeiro(CriarBarbeiroRequest criarBarbeiroRequest) {
        var (_, email, _, _) = criarBarbeiroRequest;

        _barbeiroRepository.EmailExiste(email);
        
        throw new NotImplementedException();
    }


}

