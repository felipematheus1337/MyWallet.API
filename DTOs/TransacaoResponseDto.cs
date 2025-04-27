namespace MyWalletApi.DTOs;

public class TransacaoResponseDto
{

    public int Id { get; set; }
    public string? Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data {  get; set; }
    public string? Tipo { get; set;}

    public int CarteiraId { get; set; }

}
