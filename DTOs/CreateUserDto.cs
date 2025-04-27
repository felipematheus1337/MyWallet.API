namespace MyWalletApi.DTOs;

public class CreateUserDto
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }

    public decimal Saldo { get; set; }
}
