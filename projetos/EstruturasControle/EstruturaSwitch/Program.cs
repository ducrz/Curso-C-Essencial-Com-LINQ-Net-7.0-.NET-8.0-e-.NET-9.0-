/*
Estrutura Switch em C#

O bloco switch case é uma estrutura de condição que define o código
a ser executado com base em uma comparação de valores.

Exemplo simples de uso do switch case em C#:
switch(variavel/expressao)
{
    case valor1:
        // código a ser executado se variavel/expressao == valor1
        break;
    case valor2:
        // código a ser executado se variavel/expressao == valor2
        break;
    ...
    default:
        // código a ser executado se nenhum dos casos anteriores for atendido
        break;
}
Exemplo de número de prestações:

informar o número de prestações (1 a n)

Avalia o valor informado

Caso valor igual a 1
prestação 300
sair

Caso valor igual a 2
prestacao 150
sair
Caso valor igual a 3
prestação 100
sair
Padrão
Número de prestações inválido
Sair
*/
Console.WriteLine("Estrutura Switch em C#");
int compra = 600;

Console.WriteLine("Valor da compra: R$ 600,00\n");
Console.Write("Informe o número de prestações (1 a 3): ");
int numeroPrestacoes = Convert.ToInt32(Console.ReadLine());
switch (numeroPrestacoes)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {600/numeroPrestacoes }");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {600/numeroPrestacoes }");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {600/numeroPrestacoes }");
        break;
    default:
        Console.WriteLine("Valor inválido, informe um número entre 1 e 3.");
        break;
}   

//Avaliando o valor de uma expressão: Par ou ímpar

Console.WriteLine("Informe um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine($"\nO número {numero} é par.");
        break;
    case 1:
        Console.WriteLine($"\nO número {numero} é ímpar.");
        break;
    default:
        Console.WriteLine("Erro na avaliação do número.");
        break;
}

/*
Executar o mesmo código para valores diferentes

Exemplo - dias dos meses do ano (2026)
*/
Console.WriteLine("\nInforme o nome do mês para saber a quantidade de dias:");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine($"\nO mês de {mes} tem 31 dias.");
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine($"\nO mês de {mes} tem 30 dias.");
        break;
    case "fevereiro":
        Console.WriteLine($"\nO mês de {mes} tem 28 dias em 2026.");
        break;
    default:
        Console.WriteLine("Mês inválido.");
        break;
}

/* Instruções switch case aninhadas 

*/

int cargo =0;
int funcao =0;

Console.WriteLine("Informe o código do cargo: Gerente (1)ou Programador (2)? \t");
cargo = Convert.ToInt32(Console.ReadLine());

switch (cargo)
{
    case 1:

        Console.WriteLine("\n Bem-vindo, Gerente!");
        break;
    case 2:
    Console.WriteLine("\nBem-vindo Programador!");
    switch (funcao)
    {
        case 1:
            Console.WriteLine("Função: Júnior");
            break;
        case 2:
            Console.WriteLine("Função: Sênior");
            break;
        default:
            Console.WriteLine("Função Desconhecida.");
            break;
    }
    break;
    default:
        Console.WriteLine("Cargo Desconhecido.");
        break;  
}

Console.ReadKey();