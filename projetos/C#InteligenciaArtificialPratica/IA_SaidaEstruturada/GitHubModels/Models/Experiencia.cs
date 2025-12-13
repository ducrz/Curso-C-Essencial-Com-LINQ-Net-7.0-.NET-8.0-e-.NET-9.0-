using System.ComponentModel;

namespace Github_Models.Models;

public class Experiencia
{
    [Description("Nome da empresa")]
    public required string Empresa { get; set; }

    [Description("Titulo do cargo ou posição")]
    public required string Cargo { get; set; }

    [Description("Duração no formato 'Mês - Ano' ou similar")]
    public required string Periodo { get; set; }

    [Description("Breve descrição das principais responsabilidades e conquistas")]
    public required string Descricao { get; set; }
}