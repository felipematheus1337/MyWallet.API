using MyWalletApi.DTOs;

namespace MyWalletApi.Services
{
    public interface IBusinessService
    {
        void CreateUser(CreateUserDto dto);

        Task<decimal> ObterSaldo(int usuarioId);

        void AdicionarSaldo(int usuarioId, decimal saldo);

        Task<IEnumerable<TransacaoResponseDto>> ObterTransacoes(int usuarioId);

        Task<TransacaoResponseDto> CriarTransacao(CreateTransacaoDto dto);

        Task<CarteiraResponseDto> ObterDadosCarteira(int usuarioId);
)


    }
}
