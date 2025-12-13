﻿using Github_Models.Models;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using OpenAI;
using System.ClientModel;

Console.WriteLine("=== Saída Estruturada com GitHub Models ===\n");

// Carregar configuração User Secrets
var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

var credential = new ApiKeyCredential(config["GithubToken"]
   ?? throw new InvalidOperationException("Falha na Configuração : GithubToken"));

// 2. Configurar endpoint do cliente OpenAI para GitHub Models
var options = new OpenAIClientOptions()
{
    Endpoint = new Uri("https://models.inference.ai.azure.com")
};

// 3. Criar ChatClient 
IChatClient chatClient =
    new OpenAIClient(credential, options).GetChatClient("gpt-4o-mini")
                                         .AsIChatClient();
 

Console.WriteLine(" Conectado ao GitHub Models (gpt-4o-mini) \n");
Console.WriteLine("2. ANÁLISE DE CURRÍCULO (Carregando arquivo : 'Curriculo.txt')");
Console.WriteLine("--------------------------------------------------");

try
{
    // Caminho do arquivo - AJUSTE CONFORME NECESSÁRIO
    string caminhoArquivoCurriculo = "curriculo.txt";

    // Verificar se arquivo existe
    if (!File.Exists(caminhoArquivoCurriculo))
    {
        Console.WriteLine($"Arquivo '{caminhoArquivoCurriculo}' não encontrado!");
        Console.WriteLine($"Crie um arquivo chamado '{caminhoArquivoCurriculo}' na pasta do projeto com o texto do currículo.");
        Console.WriteLine();
    }
    else
    {
        // Carregar currículo do arquivo
        string resumoTexto = File.ReadAllText(caminhoArquivoCurriculo);

        Console.WriteLine($"✅ Arquivo carregado com sucesso! ({resumoTexto.Length} caracteres)\n");

        var promptCurriculo = $@"Você é um especialista em RH. Analise o currículo abaixo e preencha o objeto Curriculo corretamente.

{resumoTexto}

Retorne SOMENTE os dados necessários para preencher o tipo Curriculo. 
NÃO retorne explicações. NÃO retorne JSON.
Apenas preencha os campos do objeto Curriculo conforme o schema enviado.";

        Console.WriteLine("⏳ Analisando currículo...\n");

        var curriculo = await chatClient.GetResponseAsync<Curriculo>(promptCurriculo);

        // Exibir resultado
        Console.WriteLine($" RESULTADO DA ANÁLISE");
        Console.WriteLine($"==========================\n");

        Console.WriteLine($"Nome: {curriculo.Result.Nome}");
        Console.WriteLine($"Email: {curriculo.Result.Email}");
        Console.WriteLine($"Telefone: {curriculo.Result.Telefone}");

        Console.WriteLine($"\n Resumo Profissional:");
        Console.WriteLine($"{curriculo.Result.ResumoProfissional}\n");

        Console.WriteLine($"Experiência Profissional ({curriculo.Result.ExperienciasProfissionais.Count}):");
        foreach (var exp in curriculo.Result.ExperienciasProfissionais)
        {
            Console.WriteLine($"  • {exp.Cargo} na {exp.Empresa}");
            Console.WriteLine($"    Período: {exp.Periodo}");
            Console.WriteLine($"    Descrição: {exp.Descricao}\n");
        }

        Console.WriteLine($"Formação Acadêmica ({curriculo.Result.FormacaoAcademica.Count}):");
        foreach (var edu in curriculo.Result.FormacaoAcademica)
        {
            Console.WriteLine($"  • {edu.Grau} em {edu.CampoEstudo}");
            Console.WriteLine($"    Instituição: {edu.InstituicaoEnsino}\n");
        }

        Console.WriteLine($"Habilidades Técnicas ({curriculo.Result.HabilidadesTecnicas.Count}):");
        Console.WriteLine($"  {string.Join(" | ", curriculo.Result.HabilidadesTecnicas)}\n");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao processar currículo: {ex.Message}\n");
}


Console.WriteLine("=== Demo Completa ===\n");
Console.ReadKey();