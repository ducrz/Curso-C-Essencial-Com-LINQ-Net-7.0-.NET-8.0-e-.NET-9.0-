using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Github_Models.Models;

public class Contato
{
    [Description("Nome completo do contato")]
    public required string Nome { get; set; }

    [Description("Email do contato")]
    public required string Email { get; set; }

    [Description("Telefone com código de área")]
    public required string Telefone { get; set; }
}