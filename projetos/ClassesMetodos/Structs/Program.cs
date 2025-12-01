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


/* Struct x Classes

Considere definir um struct em vez de uma classe se as instâncias do tipo forem pequenas e normalmente
de curta duração ou se forem comumente incorporadas em outros objetos.

Evite definir um struct, a menos que o tipo tenha todas as características a seguir:
Representa logicamente um único valor, semelhante aos tipos primitivos (int, double, etc).
Tem um tamanho de instância inferior a 16 bytes.
É imutável.
Não precisará sofrer conversão para tipo de referência (boxing) com frequência.


*/