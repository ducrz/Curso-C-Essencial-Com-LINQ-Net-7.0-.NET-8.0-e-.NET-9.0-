using System.ComponentModel;

namespace Github_Models.Models;

public class Educacao
{
    [Description("Nome da instituição de estudo")]
    public required string InstituicaoEnsino { get; set; }

    [Description("Grau obtido(e.g., Bacharelado, Mestre)")]
    public required string Grau { get; set; }

    [Description("Campo de estudo")]
    public required string CampoEstudo { get; set; }
}