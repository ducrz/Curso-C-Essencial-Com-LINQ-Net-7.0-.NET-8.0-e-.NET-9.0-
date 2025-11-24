/* Construtor em C#

Os construtores são tipos especiais de métodos usados para criar e inicializar
objetos de uma classe.

Na linguagem C# toda classe precisa de um construtor para ser instanciada.

Sempre que uma classe for instanciada usando a palavra new o seu construtor é chamado.

Ao criar uma classe, um construtor padrão (sem parâmetros) é automaticamente criado pelo compilador, ele
é usado para criar uma instância da classe (o objeto) e definir os valores padrão para os membros da classe.

Um construtor deve possuir o mesmo nome da classe e não possui um tipo de retorno, nem mesmo void.

Pode possuir parâmetros que são usados para inicializar os membros da classe.

public class Aluno{

    public Aluno(); // Construtor padrão
    public string Nome;
    public int Idade;
    public string Sexo;
    public string Aprovado;
}
*/
Console.WriteLine("Construtor em C#");

Aluno aluno = new Aluno();

//operador ternário (condição ? valor_se_verdadeiro : valor_se_falso)
Console.WriteLine(aluno.Nome == null ? "Null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade.ToString());
Console.WriteLine(aluno.Sexo == null ? "Null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "Null" : aluno.Aprovado);
public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

   
}


/* Criando um construtor com parâmetros

public class Aluno{
    public Aluno(string nome, int idade, string sexo, string aprovado){
         Nome = nome;
         Idade = idade;
         Sexo = sexo;
         Aprovado = aprovado;
    }

   public string? Nome;
   public int Idade;
   public string? Sexo;
   public string? Aprovado;

}


*/