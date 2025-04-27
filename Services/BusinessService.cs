
using AutoMapper;
using MyWalletApi.Domain;
using MyWalletApi.DTOs;
using MyWalletApi.Repositories;

namespace MyWalletApi.Services;

public class BusinessService : IBusinessService
{

    private readonly IUnitOfWork _uWork;
    private readonly IMapper _mapper;

    public BusinessService(IUnitOfWork uWork, IMapper mapper)
    {
        _uWork = uWork;
        _mapper = mapper;
    }

    public async Task AdicionarSaldo(int usuarioId, decimal saldo)
    {
        var usuario = await _uWork.UsuarioRepository
       .Get(u => u.Id == usuarioId, u => u.Carteira);

        if (usuario?.Carteira == null) throw new InvalidOperationException("Carteira não encontrada para o usuario");

        usuario.Carteira.Saldo += saldo;

        await _uWork.Commit();

    }

    public async Task CreateUser(CreateUserDto dto)
    {
        var usuario = _mapper.Map<Usuario>(dto);

        await _uWork.UsuarioRepository.Create(usuario);

        var carteira = new Carteira
        {
            Usuario = usuario,
            Saldo = dto.Saldo
        };

        await _uWork.CarteiraRepository.Create(carteira);

        await _uWork.Commit();
    }


    public async Task<TransacaoResponseDto> CriarTransacao(CreateTransacaoDto dto)
    {
        int carteiraId = dto.CarteiraId;
        var carteira = await _uWork.CarteiraRepository.Get(c => c.Id == carteiraId);

        if (carteira is null) throw new InvalidOperationException($"Carteira não encontrada com o id: {carteiraId}");

        var transacao = _mapper.Map<Transacao>(dto);

        if (transacao is null) throw new InvalidOperationException("Transação é null.");

        await _uWork.TransacaoRepository.Create(transacao);

        await _uWork.Commit();

        return _mapper.Map<TransacaoResponseDto>(transacao);

    }

    public async Task<CarteiraResponseDto> ObterDadosCarteira(int usuarioId)
    {
        var carteira = await _uWork.CarteiraRepository.Get(c => c.UsuarioId == usuarioId);
        if (carteira is null) throw new InvalidOperationException($"Carteira não encontrada para o usuario com o id: {usuarioId}");
        return _mapper.Map<CarteiraResponseDto>(carteira);
    }

    public async Task<decimal> ObterSaldo(int usuarioId)
    {
        var carteira = await _uWork.CarteiraRepository.Get(c => c.UsuarioId == usuarioId);
        if (carteira is null) throw new InvalidOperationException($"Carteira não encontrada para o usuario com o id: {usuarioId}");
        return carteira.Saldo;
    }

    public async Task<IEnumerable<TransacaoResponseDto>> ObterTransacoes(int usuarioId)
    {
        var carteira = await _uWork.CarteiraRepository.Get(c => c.UsuarioId == usuarioId, c => c.Transacoes);
        if (carteira is null) throw new InvalidOperationException($"Carteira não encontrada para o usuario com o id: {usuarioId}");

        return carteira.Transacoes.Select(_mapper.Map<TransacaoResponseDto>);
    }
}
