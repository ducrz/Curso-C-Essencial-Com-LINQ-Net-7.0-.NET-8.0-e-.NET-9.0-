/* Membros Estáticos - Campos e Propriedades

Um membro estático é definido usando o modificador static na declaração do membro.
public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

   
}


 Um campo estático não pertence ao objeto, mas a classe.
*/
Console.WriteLine("Campos Estáticos");

A a1= new A();
a1.x = 10;

A a2 = new A();
a2.x = 20;

A.y = 30;

Console.WriteLine($"a1.x = {a1.x}, a2.x = {a2.x}, A.y = {A.y}");

public class A
{
    public int x;
    public static int y;
}


