var gato = new Gato();
gato.Nome = "Mingau";
gato.ExibeNome();

var cao = new Cao();
cao.Nome = "Rex";
cao.ExibeNome();

class Animal
{
    
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        System.Console.WriteLine($"\n Meu nome é: {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome()
    {
        System.Console.WriteLine($"\n Meu nome felino é: {Nome}");
    }
}

class Cao : Animal
{
    // Usa a implementação da classe base (Animal)
}