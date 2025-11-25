Console.WriteLine("Palavra-chave This");

/* Palavra-chave This

Refere-se à instância atual da classe.

É usada como modificador do primeiro parâmetro de um método de extensão.

Representa o objeto que está em execução, e assim, usando this, de forma implícita chamamos o objeto 
que está sendo usado.


Usos comuns da Palavra-chave This:
Usada para diferenciar entre os parâmetros dos métodos e os campos quando eles
tiverem o mesmo nome.

*/

public class Cliente
{
    private string? Nome;
    private int Idade;

    public Cliente(string? nome, int idade)
    {
       this.Nome = Nome;
       this.Idade = Idade;
    }

  
}

/* Outro uso é passar um objeto da instância atual como um parâmetro para outro método.

*/

Teste t1 = new Teste();
t1.Num1 = 10;
t1.Num2 = 20;
t1.Exibir();

Teste t2 = new Teste();;
t2.Num1 = 88;
t2.Num2 = 99;
t2.Exibir();

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametros(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: "+ t.Num1);
        Console.WriteLine("Num2: "+ t.Num2);
    }
    public void Exibir()
    {
        PassarParametros(this);
    }
}



/* Outro exemplo

*/
public class Teste2
{
    public int Num1;    
    public int Num2;

    public void PassarParametros(Teste2 t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: "+ t.Num1);
        Console.WriteLine("Num2: "+ t.Num2);
    }
    public void Exibir()
    {
        PassarParametros(this);
    }
}

/* Invocar outro construtor da mesma classe.


*/
Teste t1 = new Teste(999);
public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros: {num1}, {num2}");

    }
    public Teste(int num): this(777, 888)
    {
        Console.WriteLine($"\nConstrutor com um parâmetro: {num}");
    }
}