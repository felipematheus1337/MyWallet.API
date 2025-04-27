using System.ComponentModel.DataAnnotations.Schema;

namespace MyWalletApi.Domain;


[Table("Carteira")]
public class Carteira
{
    public int Id { get; set; }
    public decimal Saldo { get; set; }
    public int UsuarioId { get; set; }
    public Usuario usuario { get; set; } = null;

    public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();


}
