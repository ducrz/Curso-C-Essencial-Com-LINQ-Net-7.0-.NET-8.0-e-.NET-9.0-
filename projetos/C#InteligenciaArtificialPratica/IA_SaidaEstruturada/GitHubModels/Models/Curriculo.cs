using System.ComponentModel;

namespace Github_Models.Models;

public class Curriculo
{

    [Description("Nome completo")]
    public required string Nome { get; set; }

    [Description("Endereço de e-mail")]
    public required string Email { get; set; }

    [Description("Número de telefone")]
    public required string Telefone { get; set; }

    [Description("Resumo profissional ou objetivo")]
    public required string ResumoProfissional { get; set; }

    [Description("Lista de experiências profissionais")]
    public required List<Experiencia> ExperienciasProfissionais { get; set; }

    [Description("Lista de formação acadêmica")]
    public required List<Educacao> FormacaoAcademica { get; set; }

    [Description("Lista de habilidades técnicas")]
    public required List<string> HabilidadesTecnicas { get; set; }
}