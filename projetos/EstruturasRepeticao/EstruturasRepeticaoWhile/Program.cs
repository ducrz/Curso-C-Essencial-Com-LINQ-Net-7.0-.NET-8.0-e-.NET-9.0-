/* Estrutura de repetição WHILE
While executa uma instrução ou bloco de instruções,
enquanto uma expressão booleana for verdadeira.

Como essa expressão é avaliada antes de cada execução do loop, um loop while
pode executar zero ou mais vezes.

while(condição)
{
    // bloco de instruções
}
O loop/laço inicial com a instrução while e deve incluir uma expressão
condicional booleana (condição) que retorna true ou false.
*/
Console.WriteLine("Estrutura de repetição WHILE");

//Exemplo - Imprimir o valor de i de 1 até 10
var i = 1; // inicialização da variável de controle
while (i <= 10) // condição de repetição
{
    Console.WriteLine($"i = {i}"); // bloco de instruções
    i++; // atualização da variável de controle
}       

//Imprimir a tabuada de um número maior que zero
Console.WriteLine("Digite um númeromaior que zero para ver a tabuada:");
var numero = Convert.ToInt32(Console.ReadLine());
if (numero > 0)
{
    var contador = 1;
    while (contador <= 10)
    {
        var resultado = numero * contador;
        Console.WriteLine($"{numero} x {contador} = {resultado}");
        contador++;
    }
}
else
{
    Console.WriteLine("Número inválido! Digite um número maior que zero.");
}

/* Instrução While - Saindo do Loop com break
A instrução break pode ser usada para encerrar uma instrução switch ou
um loop (while, for, if, etc), em uma determinada condição.

while(condicao1)
{
    if(condicao2)
    {
        break; // sai do loop
    }
    instruções;
*/
/* Exemplo - Informar se um número é par ou ímpar, usando um loop infinito
para capturar a entrada do teclado e saindo do loop usando a instrução break
*/
while (true) // loop infinito
{
    Console.WriteLine("Digite um número inteiro (ou '999' para encerrar):");
        var numero = Convert.ToInt32(Console.ReadLine());
        if (numero == 999) // condição de saída do loop
        {
            break; // sai do loop   
        }
        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é PAR.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ÍMPAR.");
        }
        
}    

/* Instruções while aninhadas
while(condicao1)
{
    instruções;
    while(condicao2)
    {
        instruções;
    }
}

Exemplo: Coordenadas do plano (x,y) - 0 até 5

*/
var x = 0;
while (x <= 5)
{
    var y = 0;
    while (y <= 5)
    {
        Console.WriteLine($"Coordenadas: ({x},{y})");
        y++;
    }
    x++;
}

Console.ReadKey();