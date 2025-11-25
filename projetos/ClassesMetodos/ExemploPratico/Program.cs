/* Exemplo Prático


*/
Console.WriteLine("Exemplo Prático de Classes e Métodos");

Cliente cliente1 = new Cliente();



public class Cliente


{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
    public Cliente()
    {
        
    }
    
}


public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    }
        public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome}, {cliente.Idade} {cliente.Renda}" );
       
    }
        public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"{texto}");
        Console.WriteLine($"{cliente.Nome}, {cliente.Renda}" );
       
    }
}