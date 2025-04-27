
using MyWalletApi.DTOs;
using MyWalletApi.Repositories;

namespace MyWalletApi.Services;

public class BusinessService : IBusinessService
{

    private readonly IUnitOfWork _uWork;

    public BusinessService(IUnitOfWork uWork)
    {
        _uWork = uWork;
    }

    public void AdicionarSaldo(int usuarioId, decimal saldo)
    {
        throw new NotImplementedException();
    }

    public void CreateUser(CreateUserDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<TransacaoResponseDto> CriarTransacao(CreateTransacaoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<CarteiraResponseDto> ObterDadosCarteira(int usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> ObterSaldo(int usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TransacaoResponseDto>> ObterTransacoes(int usuarioId)
    {
        throw new NotImplementedException();
    }
}
