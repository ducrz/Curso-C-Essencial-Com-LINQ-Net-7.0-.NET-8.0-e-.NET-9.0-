using System.ComponentModel;

namespace IA_SaidaEstruturada.Model;

internal class Contato
{
    [Description("Nome completo da pessoa")]
    public required string Nome { get; set; }

    [Description("Endereço de email")]
    public required string Email { get; set; }

    [Description("Número de telefone com DDD")]
    public required string Telefone { get; set; }
}