using MyWalletApi.DTOs;

namespace MyWalletApi.Services
{
    public interface IBusinessService
    {
        Task CreateUser(CreateUserDto dto);

        Task<decimal> ObterSaldo(int usuarioId);

        Task AdicionarSaldo(int usuarioId, decimal saldo);

        Task<IEnumerable<TransacaoResponseDto>> ObterTransacoes(int usuarioId);

        Task<TransacaoResponseDto> CriarTransacao(CreateTransacaoDto dto);

        Task<CarteiraResponseDto> ObterDadosCarteira(int usuarioId);
)


    }
}
