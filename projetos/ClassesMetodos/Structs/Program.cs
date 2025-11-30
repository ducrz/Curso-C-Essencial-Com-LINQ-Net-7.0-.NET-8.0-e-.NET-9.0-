/* Structs
Estruturas que são modelos para criar objetos.

É um tipo de dado definido pelo usuário que é composta por outros
tipos de dados e funcionalidades relacionadas (semelhantes a uma classe).

Uma struct pode conter campos, métodos, constantes, construtores, propriedades,
indexadores, operadores e mesmo outros tipos de estruturas.

A principal diferença entre classe e structs é que structs são tipos
de valor, enquanto classes são tipos de referência.

struct - sintaxe

struct <nome_do_tipo>{
    //membros: campos, propriedades, métodos, construtor, etc.
}


*/
Console.WriteLine("Structs em C#");

Cliente cliente = new Cliente();

cliente.Nome = "João";
cliente.Idade = 30;

Console.WriteLine($"{cliente.Nome} - {cliente.Idade}");
struct Pessoa{
    public string Nome;
    public int Idade { get; set; }

    public void Exibir{
        Console.WriteLine("Struct");
    }
}

public struct Cliente{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade){
        Nome = nome;
        Idade = idade;
    }
}
