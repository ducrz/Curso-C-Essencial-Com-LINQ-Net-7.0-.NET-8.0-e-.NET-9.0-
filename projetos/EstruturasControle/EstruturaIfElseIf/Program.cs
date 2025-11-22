/* Instrução If-Else-If

Podemos usar instruções else if após a instrução if para avaliar mais de uma condição.
As instruções else if somente serão executadas se a condição na instrução if for falsa.

Portanto: a instrução if será executada ou uma das instruções else if será executada,
mas não ambas.

A instrução if pode ter várias cláusulas else if onde cada cláusula tem uma condição.

A instrução else if verifica cada condição de cima para baixo sequencialmente,
e, se uma condição for verdadeira, o bloco correspondente é executado e as demais 
condições não serão avaliadas.

if (condicao1)
{
    //executa se condicao1 for true
    //instrucao
}
else if (condicao2)
{
    //executa se condicao1 for false e condicao2 for true
    //instrucao    
}
else if (condicao3)
{
    //executa se condicao1 for false, condicao2 for false e condicao3 for true
    //instrucao
}
else
{
    //executa se todas as condicoes anteriores forem false
    //instrucao
}
//Possível utilizar sem o else final
*/
Console.WriteLine("Instrução If-Else-if");

/* Aluno reprovado, recuperação, aprovado e aprovado com distinção
Informar a nota do aluno

se nota menor que 5.0 -> reprovado
se nota entre 5.0 e 6.0 -> recuperação
se nota maior ou igual a 6 e menor que 9.0 -> aprovado
se nota maior ou igual a 9.0 -> aprovado com distinção

*/
Console.Write("Informe a nota do aluno: \t");
double nota = Convert.ToDouble(Console.ReadLine()); 
if (nota < 5.0)
{
    Console.WriteLine("\nAluno reprovado.");
}
else if (nota >= 5.0 && nota < 6.0)
{
    Console.WriteLine("\nAluno em recuperação.");
}
else if (nota >= 6.0 && nota < 9.0)
{
    Console.WriteLine("\nAluno aprovado.");
}
else if(nota >= 9.0) //nota >= 9.0
{
    Console.WriteLine("\nAluno aprovado com distinção.");
}
Console.ReadKey();