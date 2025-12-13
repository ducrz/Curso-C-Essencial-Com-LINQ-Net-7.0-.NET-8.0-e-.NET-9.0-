using Microsoft.Extensions.AI;
using OllamaSharp;

IChatClient clientChat = 
    new OllamaApiClient(new Uri("http://localhost:11434/"), "gpt-oss:20b");

List<ChatMessage> historicoChat = new();

Console.WriteLine("Chat GPT-OSS - Digite 'sair' para encerrar");

Console.WriteLine();

while (true)
{
    Console.Write("Voce: ");
    var entradaUsuario = Console.ReadLine();

    if (entradaUsuario?.ToLower() == "sair")
        break;

    if (string.IsNullOrWhiteSpace(entradaUsuario))
        continue;

    historicoChat.Add(new ChatMessage(ChatRole.User, entradaUsuario));

    Console.Write("Assistente: ");

    var respostaAssistente = "";

    await foreach (var atualizacao in clientChat.GetStreamingResponseAsync(historicoChat))
    {
        Console.Write(atualizacao.Text);
        respostaAssistente += atualizacao.Text;
    }

    historicoChat.Add(new ChatMessage(ChatRole.Assistant, respostaAssistente));
    Console.WriteLine();
    Console.WriteLine();

}