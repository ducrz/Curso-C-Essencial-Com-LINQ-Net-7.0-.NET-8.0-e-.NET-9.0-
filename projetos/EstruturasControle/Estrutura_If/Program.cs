Console.WriteLine("Instrução If");

Console.WriteLine("Cliente Especial (S/N)");
var resposta = Console.ReadLine();

if(resposta == "S")
{
    Console.WriteLine("Desconto de 10%");
}

Console.ReadKey();

/* Usando True or false */

Console.WriteLine("Cliente Especial (true/false)");
var resposta = Console.ReadLine();

if(resposta)
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do Processamento!");
Console.ReadKey();

/* Comparar se x é maior, menor ou igual a y */
Console.Write("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}
if (x < y)
{
    Console.WriteLine("x é menor que y");
}
if (x == y)
{
    Console.WriteLine("x é igual a y");
}


Console.ReadKey();







