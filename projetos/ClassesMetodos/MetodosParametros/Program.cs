Console.WriteLine("Métodos com Parâmetros");

/* Método com Parâmetros

Um parâmetro é um valor passado para o método.

Os métodos podem receber um ou mais parâmetros, que são espeficidados dentro
dos parênteses, após a definição do nome do método, e, são separados por vírgulas.

Na definição do método, devemos informar o tipo e o nome do parâmetro.

public void Saudacao(string nome, string data) 
{
    Console.WriteLine($"Olá {nome}, hoje é {data}");
}   


public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine($"Olá {nome}, hoje é {data}");
    }

}

Chamar ou invocar o método:

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao("Maria", DateTime.Now.ToShortDateString());


*/


Console.ReadKey(); 

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao("Maria", DateTime.Now.ToShortDateString());
public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine($"Olá {nome}, hoje é {data}");
    }

}

/* Passando parâmetros entre classes

public class Aluno{
    public string Nome;
    public int Idade;
    public string Sexo;
    public string Aprovado;
   
}
public class Curso
{
    public void Resultado(string nome, int idade, string sexo, string aprovado)
    {
        Console.WriteLine($"O aluno: {nome}, sexo: {sexo}, com {idade} anos");
        if (aprovado == "Sim")
        {
            Console.WriteLine("foi aprovado!");
        }
        else
        {
            Console.WriteLine("não foi aprovado!");
        }
    }
}

Criar um objeto da classe Aluno e atribuir valores aos atributos da classe.

Acessar o método Resultado da classe Curso e passar os valores para o método.

*/
Aluno aluno1 = new Aluno();
aluno1.Consultar();

var aluno = new Aluno();
Console.WriteLine("Digite o nome do aluno:");
aluno.Nome=Console.ReadLine();
Console.WriteLine("Digite a idade do aluno:");
aluno.Idade=int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o sexo do aluno:");
aluno.Sexo=Console.ReadLine();
Console.WriteLine("O aluno foi aprovado? (S/N):");
aluno.Aprovado=Console.ReadLine();

Curso curso = new Curso();
//curso.Resultado(aluno.Nome!, aluno.Idade, aluno.Sexo!, aluno.Aprovado!);
curso.Resultado(aluno);

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    //public void Resultado(string nome, int idade, string sexo, string aprovado)
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno: {aluno.Nome}, sexo: {aluno.Sexo}, com {aluno.Idade} anos");
        if (aluno.aprovado == "Sim")
        {
            Console.WriteLine("foi aprovado!");
        }
        else
        {
            Console.WriteLine("não foi aprovado!");
        }
    }
}

/* Passando um tipo de referência por valor

Quando um tipo de referência é passado por valor a um método, esse método receberá uma cópia
da referência para a instância da classe.

O método chamado recebe uma cópia do endereço da instância e o método de chamada
retém o endereço original da instância.

A instância de classe no método de chamada tem um endereço, 
o parâmetro do método chamado tem uma cópia do endereço e os dois endereços se referem ao mesmo objeto.

*/

public void Consultar()
{
    var aluno = new Aluno();
    Console.WriteLine("Digite o nome do aluno:");
    aluno.Nome = Console.ReadLine();
    Console.WriteLine("Digite a idade do aluno:");
    aluno.Idade = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o sexo do aluno:");
    aluno.Sexo = Console.ReadLine();
    Console.WriteLine("O aluno foi aprovado? (S/N):");
    aluno.Aprovado = Console.ReadLine();    

    Curso curso = new Curso();
    curso.Resultado(aluno);
}