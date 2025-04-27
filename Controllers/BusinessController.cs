using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyWalletApi.DTOs;
using MyWalletApi.Services;

namespace MyWalletApi.Controllers;

[Route("[controller]")]
[ApiController]
public class BusinessController : ControllerBase
{
    private readonly IBusinessService _service;

    public BusinessController(IBusinessService service)
    {
        _service = service;
    }

    [HttpPost("saldo/")]
    public async Task<ActionResult> AdicionarSaldo([FromQuery] IncrementSaldoParameter saldoParams)
    {
        await _service.AdicionarSaldo(saldoParams);

        return Created();
    }

    [HttpPost("user/")]
    public async Task<ActionResult> CriarUsuario([FromBody] CreateUserDto dto)
    {
        await _service.CreateUser(dto);

        return Created();
    }

    [HttpPost("transacao/")]
    public async Task<ActionResult<TransacaoResponseDto>> CriarTransacao([FromBody] CreateTransacaoDto dto)
    {
        var transacao = await _service.CriarTransacao(dto);

        if (transacao == null) return BadRequest();

        return Created(string.Empty, transacao);
    }

    [HttpGet("saldo/{id:int}")]
    public async Task<ActionResult> ObterSaldo(int id)
    {
        decimal saldo = await _service.ObterSaldo(id);

        return Ok(saldo);
    }

    [HttpGet("carteira/{id:int}")]
    public async Task<ActionResult> ObterCarteira(int id)
    {
        var carteira = await _service.ObterDadosCarteira(id);

        return Ok(carteira);
    }

    [HttpGet("transacoes/{id:int}")]
    public async Task<ActionResult<IEnumerable<TransacaoResponseDto>>> ObterTransacoes(int id)
    {
        var transacoes = await _service.ObterTransacoes(id);

        if (transacoes == null) return BadRequest();

        return Ok(transacoes);
    }
}
