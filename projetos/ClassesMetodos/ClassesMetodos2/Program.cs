internal class Program
{
private static void Main(string[] args)
{   
    Console.WriteLine("Métodos e Classes em C#");
    Console.ReadKey();

}

}

/* Método ou Função?

C# é uma linguagem orientada a objetos que não possui funções
dclaradas fora das classes.

Não linguagem C#, a rigor, não existem funções mas métodos.

Criando métodos - Sintaxe mínima

Tipo de Retorno - Determina o tipo de valor que o método retorna
Se o método não retorna nenhum valor, usamos o tipo "void"

Nome - Define o nome do método (Pascal Case)

Lista de parâmetros - Indica o tipo de dado e o valor das variáveis/objetos
que o método pode receber. (São indicados entre parênteses após o nome do método).

Corpo do método - Consiste das instruções definidas entre chaves no corpo
do método.

class MinhaClasse{
void Saudacao(){
    Console.WriteLine("Bem-vindo ao C#");
    Console.WriteLine("24/11/2025");
}
}

*/

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
minhaClasse.ExibirDataAtual();
class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-vindo ao C#");
        ExibirDataAtual();
    }
    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}