public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set;  } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("Construtor parametrizado chamado");
                Console.WriteLine("Inicializando o campo IdadeMinima no construtor estático");

        Idade = idade;
        Nome = nome;
    }
    public Pessoa()
    {
        IdadeMinima= 18;

    }
}
