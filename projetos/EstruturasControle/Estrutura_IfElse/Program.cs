/* Instrução IF-Else
A instrução if-else é composta por dois blocos de instruções: o bloco de
instruções if e o bloco de instruções else.

*/
Console.WriteLine("Estrutura de Controle IF-ELSE");

Console.ReadLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());


if (nota > 5)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");

}
Console.ReadKey();

/* Comparar se x é maior, menor ou igual a y */
Console.ReadLine("Informe o valor de x \t");
var x= Convert.ToInt32(Console.ReadLine());
Console.ReadLine("Informe o valor de y \t");
var y= Convert.ToInt32(Console.ReadLine());


if (x > y)
{
    Console.WriteLine("x é maior que y!");
}
else
{
    if (x < y) //Solução com if-else aninhados
    {
        Console.WriteLine("x é menor que y!");
    }
    else
    {
        Console.WriteLine("x é igual a y!");

    }
}
Console.ReadKey();
