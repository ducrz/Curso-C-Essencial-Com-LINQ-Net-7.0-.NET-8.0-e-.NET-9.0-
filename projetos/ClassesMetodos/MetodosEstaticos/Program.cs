/* Métodos Estáticos em C#

Um método estático é definido usando o modificador static na declaração do método.

public TipoRetorno NomeDoMetodo(parametros)
{
    // instruções
}

Método estático

public static TipoRetorno NomeMetodo(parametros)
{
    // instruções
}

O modificador static pode ser usado em classes, interface, structs, campos, métodos, propriedades, operadores
e construtores.

O que são métodos estáticos?
Os métodos estáticos são métodos que não dependem de um objeto ou seja, não dependem da criação de uma
instância da classe para serem acessados.

Os métodos estáticos pertencem à classe e não ao objeto.

Como o método estático não possui ligação com um objeto, ele não pode usar variáveis de instância,
que são variáveis do objeto.

Exemplos: Classes Math e Console, método Main

*/
Console.WriteLine("Métodos Estáticos em C#");

Calculadora calc= new ();

var soma = Calculadora.Somar(10, 10);
var subtracao = Calculadora.Subtrair(10, 5);
var multiplicacao = Calculadora.Multiplicar(10, 5);
var divisao = Calculadora.Dividir(10, 2);

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");


public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
