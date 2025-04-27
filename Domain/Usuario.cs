using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWalletApi.Domain;


[Table("Usuario")]
public class Usuario
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Nome { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
    public string? SenhaHash { get; set; }

    public Carteira Carteira { get; set; }
}
