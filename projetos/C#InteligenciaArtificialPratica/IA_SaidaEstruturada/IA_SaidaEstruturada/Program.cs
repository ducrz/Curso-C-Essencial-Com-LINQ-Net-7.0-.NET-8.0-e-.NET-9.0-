﻿// Conectar ao Ollama
using IA_SaidaEstruturada.Model;
using Microsoft.Extensions.AI;
using OllamaSharp;

IChatClient chatClient = new OllamaApiClient(
            new Uri("http://localhost:11434"),
            "llama3.1"
        );

Console.WriteLine("\nUsando Saída Estruturada com Ollama\n");

// Fazer a chamada com GetResponseAsync<T>()
var prompt = @"Extraia a informação do contato deste texto: Meu nome é João Silva, brasileiro, solteiro residente em São Paulo e você pode me contatar pelo e-mail joao@email.com ou pelo telefone +55 11 99876-5432.";
Console.WriteLine($"Prompt:\n{prompt}\n");

Console.WriteLine("Pressione algo para iniciar...\n");
Console.ReadKey();
Console.WriteLine("Processando...\n");

// Use GetResponseAsync<T>() - o Microsoft.Extensions.AI se encarrega de tudo!
var response = await chatClient.GetResponseAsync<Contato>(prompt);

Console.WriteLine("Resposta Estruturada:");

Console.WriteLine($"Nome: {response.Result.Nome}");
Console.WriteLine($"Email: {response.Result.Email}");
Console.WriteLine($"Fone: {response.Result.Telefone}");

Console.ReadLine();