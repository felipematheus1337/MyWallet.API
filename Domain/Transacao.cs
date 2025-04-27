namespace MyWalletApi.Domain;

public class Transacao
{
    public int Id { get; set; }
    public string Descricao { get; set; } = null!;
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public string Tipo { get; set; } = null!;

    public int CarteiraId { get; set; }
    public Carteira Carteira { get; set; } = null!;
}
