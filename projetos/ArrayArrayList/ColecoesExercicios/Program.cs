/* Exercícios
1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach


2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
etapas a seguir
b- Exiba os nomes da segunda e da penúltima fruta no console
a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
c-) Solicite ao usuário um valor de um número inteiro a procurar no array
d-) Exiba se o número informado existe no array de inteiros ou não
e-) Repita até que o texto ‘fim’ seja inserido via teclado
d- Ordene a coleção de frutas na ordem ascendente
e- Exiba no console a coleção de nomes de frutas na ordem inversa

Exercícios
3-Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).

4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.
a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
para imprimir o nome e a idade;
b-) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
armazenando as informações na ArrayList.
c-) A seguir exiba no console a lista das pessoas com nome e idade
d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
e-) Remova o último elemento da coleção e exiba a lista completa
Use seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18

5- Dada uma classe Produto contendo duas propriedades : Nome (string) e Preco (decimal). Crie uma lista
de objetos do tipo Produto usando os seguinte dados:
Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55
A seguir realize as seguintes operações na lista de objetos Produto criada :
1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
preço dos produtos e a quantidade de produtos na lista
2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
3- Ordene a lista pelo nome do produto e exiba a lista ordenada
4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
5- Localize na lista o produto com nome Estojo
6- Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número
variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método
GetType() herdado de Object) no console.
Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)

7- Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo
10 elementos.
Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado.

*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;      

namespace ColecoesExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chame aqui os métodos para testar os exercícios
        }
    }
}       

/*1- Exercício 1 
1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
b- Exiba os nomes da segunda e da penúltima fruta no console
d- Ordene a coleção de frutas na ordem ascendente
e- Exiba no console a coleção de nomes de frutas na ordem inversa
*/

public class Exercicio1
{
    public static void Executar()
    {
        string[] frutas = new string[]
        {
            "Maça", "Banana", "Laranja", "Uva", "Manga",
            "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
        };

        // a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
        Console.WriteLine("Usando for:");
        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine(frutas[i]);
        }
        Console.WriteLine($"Quantidade de frutas: {frutas.Length}");

        Console.WriteLine("\nUsando foreach:");
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        // b- Exiba os nomes da segunda e da penúltima fruta no console
        Console.WriteLine($"\nSegunda fruta: {frutas[1]}");
        Console.WriteLine($"Penúltima fruta: {frutas[frutas.Length - 2]}");

        // d- Ordene a coleção de frutas na ordem ascendente
        Array.Sort(frutas);
        Console.WriteLine("\nFrutas ordenadas em ordem ascendente:");
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        // e- Exiba no console a coleção de nomes de frutas na ordem inversa
        Array.Reverse(frutas);
        Console.WriteLine("\nFrutas em ordem inversa:");
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}

/*2- Exercício 2
2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
etapas a seguir

a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
c-) Solicite ao usuário um valor de um número inteiro a procurar no array
d-) Exiba se o número informado existe no array de inteiros ou não
e-) Repita até que o texto ‘fim’ seja inserido via teclado
*/
public class Exercicio2
{
    public static void Executar()
    {
        Console.Write("Informe o número de valores do array: ");
        int tamanho = int.Parse(Console.ReadLine());
        int[] numeros = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Informe o valor inteiro para a posição {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            Console.Write("Informe um número inteiro para pesquisar (ou 'fim' para sair): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "fim")
                break;

            int valorProcurado;
            if (int.TryParse(input, out valorProcurado))
            {
                if (numeros.Contains(valorProcurado))
                {
                    Console.WriteLine($"O número {valorProcurado} existe no array.");
                }
                else
                {
                    Console.WriteLine($"O número {valorProcurado} não existe no array.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, informe um número inteiro ou 'fim'.");
            }
        }
    }
}


/*3- Exercício 3
3-Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).
*/
public class Exercicio3
{
    public static void Executar()
    {
        float[,] notas = new float[2, 5];

        for (int grupo = 0; grupo < 2; grupo++)
        {
            for (int aluno = 0; aluno < 5; aluno++)
            {
                Console.Write($"Informe a nota do aluno {aluno + 1} do grupo {grupo + 1}: ");
                notas[grupo, aluno] = float.Parse(Console.ReadLine());
            }
        }

        for (int grupo = 0; grupo < 2; grupo++)
        {
            float soma = 0;
            for (int aluno = 0; aluno < 5; aluno++)
            {
                soma += notas[grupo, aluno];
            }
            float media = soma / 5;
            Console.WriteLine($"Média do grupo {grupo + 1}: {media}");
        }
    }
}

/*4- Exercício 4

4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.
a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
para imprimir o nome e a idade;
b-) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
armazenando as informações na ArrayList.
c-) A seguir exiba no console a lista das pessoas com nome e idade
d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
e-) Remova o último elemento da coleção e exiba a lista completa
Use seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18
*/

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}   

public class Exercicio4
{
    public static void Executar()
    {
        ArrayList pessoas = new ArrayList();

        // Dados iniciais
        pessoas.Add(new Pessoa("Ana", 22));
        pessoas.Add(new Pessoa("Diná", 21));
        pessoas.Add(new Pessoa("Maria", 19));

        // Exibir lista inicial
        Console.WriteLine("Lista inicial de pessoas:");
        ExibirPessoas(pessoas);

        // Incluir mais duas pessoas
        pessoas.Add(new Pessoa("Jaime", 20));
        pessoas.Add(new Pessoa("Tânia", 18));

        // Exibir nova lista
        Console.WriteLine("\nLista após inclusão de mais duas pessoas:");
        ExibirPessoas(pessoas);

        // Remover o último elemento
        pessoas.RemoveAt(pessoas.Count - 1);

        // Exibir lista completa após remoção
        Console.WriteLine("\nLista após remoção do último elemento:");
        ExibirPessoas(pessoas);
    }

    private static void ExibirPessoas(ArrayList pessoas)
    {
        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.Exibir();
        }
    }
}       
/*5- Exercício 5
Exercícios
5- Dada uma classe Produto contendo duas propriedades : Nome (string) e Preco (decimal). Crie uma lista
de objetos do tipo Produto usando os seguinte dados:
Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55
A seguir realize as seguintes operações na lista de objetos Produto criada :
1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
preço dos produtos e a quantidade de produtos na lista
2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
3- Ordene a lista pelo nome do produto e exiba a lista ordenada
4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
5- Localize na lista o produto com nome Estojo

*/

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}   

public class Exercicio5
{
    public static void Executar()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto("Clips", 3.95m),
            new Produto("Caneta", 5.99m),
            new Produto("Lápis", 4.15m),
            new Produto("Estojo", 6.99m),
            new Produto("Caderno", 7.55m)
        };

        // 1- Exibir relação de produtos, soma total, média e quantidade
        ExibirRelacaoProdutos(produtos);

        // 2- Incluir Mochila e exibir novamente
        produtos.Add(new Produto("Mochila", 22.44m));
        Console.WriteLine("\nApós incluir Mochila:");
        ExibirRelacaoProdutos(produtos);

        // 3- Ordenar pelo nome e exibir
        var produtosOrdenados = produtos.OrderBy(p => p.Nome).ToList();
        Console.WriteLine("\nProdutos ordenados pelo nome:");
        ExibirRelacaoProdutos(produtosOrdenados);

        // 4- Produtos com preço inferior a R$ 5,00
        var produtosBaratos = produtos.Where(p => p.Preco < 5.00m).ToList();
        Console.WriteLine("\nProdutos com preço inferior a R$ 5,00:");
        ExibirRelacaoProdutos(produtosBaratos);

        // 5- Localizar produto com nome Estojo
        var estojo = produtos.FirstOrDefault(p => p.Nome == "Estojo");
        if (estojo != null)
        {
            Console.WriteLine($"\nProduto encontrado: {estojo.Nome}, Preço: R$ {estojo.Preco}");
        }
        else
        {
            Console.WriteLine("\nProduto 'Estojo' não encontrado.");
        }
    }

    private static void ExibirRelacaoProdutos(List<Produto> produtos)
    {
        decimal soma = 0;
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: R$ {produto.Preco}");
            soma += produto.Preco;
        }
        decimal media = produtos.Count > 0 ? soma / produtos.Count : 0;
        Console.WriteLine($"Soma total: R$ {soma}, Média: R$ {media}, Quantidade: {produtos.Count}");
    }
}   

/*6- Exercício 6
6- Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número
variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método
GetType() herdado de Object) no console.
Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)
*/
public class Exercicio6
{
    public static void Executar()
    {
        ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
    }

    public static void ProcessaObjetos(params object[] objetos)
    {
        foreach (var obj in objetos)
        {
            if (obj != null)
            {
                Console.WriteLine($"Valor: {obj}, Tipo: {obj.GetType()}");
            }
            else
            {
                Console.WriteLine("Valor: null, Tipo: null");
            }
        }
    }
}   
public class Teste
{
    public override string ToString()
    {
        return "Objeto da classe Teste";
    }
}   

/*7- Exercício 7
7- Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo
10 elementos.
Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado.

*/
public class Aluno
{
    private string[] nomes = new string[10];

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= nomes.Length)
                throw new IndexOutOfRangeException("Índice fora do intervalo.");
            return nomes[index];
        }
        set
        {
            if (index < 0 || index >= nomes.Length)
                throw new IndexOutOfRangeException("Índice fora do intervalo.");
            nomes[index] = value;
        }
    }
}   

public class Exercicio7
{
    public static void Executar()
    {
        Aluno aluno = new Aluno();

        // Atribuir nomes usando o indexador
        aluno[0] = "Ana";
        aluno[1] = "Bruno";
        aluno[2] = "Carla";

        // Obter e exibir nomes usando o indexador
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Aluno {i + 1}: {aluno[i]}");
        }
    }
}   
