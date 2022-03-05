namespace Barbearia.Data.Interfaces;
public interface IBarbeiroRepository {
    Task<bool> EmailExiste(string email);
}

