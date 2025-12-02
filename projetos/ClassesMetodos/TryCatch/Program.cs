/* Tratamento de Erros: Try-Catch

Tratamento de Exceção

Uma exceção é um erro que ocorre em tempo de execução em um programa, que viola uma condição
que não foi especificada para acontecer durante a operação normal.

Se o programa não fornecer o código para tratar uma exceção, o sistema vai parar a execução
do programa com uma mensagem de erro. (lançar uma exceção)

Para lidar com exceções, a linguagem C# fornece o suporte interno através do uso do bloco:
try-catch

try{
    // código que pode gerar uma exceção
}
catch(Exception ex){
    // código para tratar a exceção
}

A instrução try-catch consiste em um bloco try seguido por uma ou mais cláusulas catch,
que especificam manipuladores para diferentes exceções.
*/
Console.WriteLine("\nInforme o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");

    Console.WriteLine($"\n Erro: <<< {ex.Message} >>>");
    Console.WriteLine($"\n Detalhes : {ex?.StackTrace?.ToString()}");

}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}

Console.ReadKey();