/* Exercício Prático 8
w3- Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade
do tipo int
w4- Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao
valor da idade.
w5- Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros
de entrada para criar um objeto do tipo Cliente
w6- Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e
idade e exiba as informações de Nome, Email e Idade. Defina idade como um parâmetro opcional.
w7- Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas
vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e
na segunda não informe o ano.
w8- Explique o que uma struct e qual a principal diferença entre struct e classe

*/
Console.WriteLine("Exercício Prático 8");

Cliente cliente = new Cliente("João Silva", "joao.silva@example.com", 25);
Cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email, idade: cliente.Idade);
Cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email);   

struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;          

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
            }
            else
            {
                idade = value;
            }
        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        this.idade = 18; // Inicializa com valor padrão
        Idade = idade; // Usa a propriedade para aplicar a validação
    }

    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}, Email: {email}, Idade: {idade}");
    }
}
/* Uma struct (estrutura) em C# é um tipo de dado definido pelo usuário que pode conter membros como campos, propriedades e métodos.
A principal diferença entre struct e classe é que structs são tipos de valor, enquanto classes são tipos de referência. Isso significa que quando você cria uma instância de uma struct, ela é armazenada diretamente na pilha de memória, e quando você a atribui a outra variável, uma cópia dos dados é feita. Por outro lado, quando você cria uma instância de uma classe, ela é armazenada no heap de memória, e a variável contém uma referência para o objeto. Portanto, ao atribuir uma variável de classe a outra, ambas apontam para o mesmo objeto na memória. 
Além disso, structs não suportam herança como classes.

 */        

    