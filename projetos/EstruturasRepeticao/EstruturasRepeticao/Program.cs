/* Estruturas de Repetição em C# 
São usadas para repetir instruções e ou blocos de código.
A instrução goto e label

Goto
Pode ser usada para transferir o controle para outra parte do programa,
com a ajuda de um identificador chamado de label.
Exemplo:

label:
    //código a ser executado

    condicao
        goto label; //transfere o controle para o label
*/
Console.WriteLine("Estruturas de Repetição em C#");


/* Exemplo: Imprimir o valor de uma variável i iniciando com o valor 1
e incrementando seu valor até que i seja igual a 10.

*/
int i = 1;
repetir: //label
    Console.WriteLine($"i = {i} ");
    i++;
    if (i <= 10)
        goto repetir;

Console.WriteLine("Fim da repetição.");
Console.ReadKey();