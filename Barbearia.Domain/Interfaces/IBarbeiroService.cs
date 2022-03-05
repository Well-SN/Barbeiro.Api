
using Barbearia.Shareable.Requests;
using OperationResult;

namespace Barbearia.Domain.Interfaces;
public interface IBarbeiroService {
    Task<Result> CriarBarbeiro(CriarBarbeiroRequest criarBarbeiroRequest);
}

