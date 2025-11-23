/* Estrutura de Repetição Do While
  O loop do-while é uma variante do loop while e possui o mesmo comportamento.
  A diferença é que o loop do-while executa o bloco de código
  pelo menos uma vez, antes de avaliar a condição, em seguida, repete
  o loop enquanto a condição for verdadeira.

  do
  {
      // bloco de código a ser executado
  } while (condição);

  O loop inicia com a instrução do seguida por um bloco de código que será executado
  e a seguir avalia uma expressão booleana com a instrução while.

  A execução será interrompida quando uma condição booleana for avaliada como falsa/false.

  Note que a expressão condicional aparece no final do loop, as instruções
  no loop são executadas pelo menos uma vez antes que a condição
  seja testada.

*/

//Exemplo: Imprimir o valor de uma variável i de 1 a 10
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 10);
    

/* Imprimir o valor da variável de 1 a 10 e sair do loop quando i for maior que 7

*/
i = 1;;
do
{
    Console.WriteLine(i);
    if (i > 7)
    {
        break; // Sai do loop quando i for maior que 7
    }
    i++;
} while (i <= 10);


/* Instrução do-while aninhadas
do
{
    do{
        //instruções
        } while (condição2);
         //instruções
    }
while (condição1);

*/  
Console.WriteLine("Estrutura de Repetição Do While");

//Exemplo: exibir coordenadas do plano (x,y), de 0 até 5
int x = 0, y = 0;
do
{
    y = 0;
    do
    {
        Console.WriteLine($"Coordenadas: ({x},{y})");
        y++;
    } while (y <= 5);
    x++;
} while (x <= 5);   


Console.ReadKey();
