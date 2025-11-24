/* Break e Continue em estruturas de repetição


*/
Console.WriteLine("Break e Continue em estruturas de repetição\n");

/* break
A instrução break é usada para sair imediatamente de um loop (for, while, do-while ou switch). Quando o break é encontrado dentro de um loop, a execução do loop é interrompida e o controle é transferido para a próxima instrução após o loop.

for(inicialização; condição; incremento) {
    if(condição_de_parada) {
        break; // Sai do loop
    }
    // Código do loop
}

*/
for (; ; ) //Loop infinito
{
    Console.Write("Tecle algo (x para sair): ");
    var opcao = Console.ReadLine();
    Console.WriteLine(opcao.ToUpper());
    if(opcao == "X"  || opcao == "x")
    {
        break;
    }


}
Console.ReadKey();

/* continue
A instrução continue interrompe uma iteração (no loop), se ocorrer uma 
condição específica,retorna e verifica a condição do loop e continua
com a próxima iteração do loop.

for(inicialização; condição; iteração) {
    if(condição_de_pular) {
        continue; // Pula para a próxima iteração
    }
    // Código do loop
}
*/
for(int i=1; i <=10; i++)
{
    if(i ==4)
    {
        continue; // Pula o número 4
    }
    Console.WriteLine(i);
}

Console.ReadKey();

/* Continue
Exemplo com loop while

*/

int n=1;
while(n <=10)
{
    if(n == 5)
    {
        n= n+1;
        continue; // Pula o número 4
    }
    Console.WriteLine($"n = {n}");
    n++;
}

Console.ReadKey();

/* Podemos usar instruções  break e continue em um mesmo loop
*/

for(int i=1; i <=10; i++)
{
    if(i == 5)
    {
        continue;
    }
    if(i > 8)
    {
        break;
    }
   
    Console.WriteLine($"{i}");
}

Console.ReadKey();



