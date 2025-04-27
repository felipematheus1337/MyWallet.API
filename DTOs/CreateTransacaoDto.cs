namespace MyWalletApi.DTOs;

public class CreateTransacaoDto
{
    public string? Descricao {  get; set; }
    public decimal Valor { get; set; } 
    public string? Tipo { get; set; }
    public int CarteiraId { get; set; }
}
