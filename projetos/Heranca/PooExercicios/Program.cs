/* Exercícios

1- Uma classe derivada pode interromper a herança virtual declarando um override como :
( ) inherits ( ) extends ( ) private ( ) not inheritable ( ) sealed
Resposta: ( X ) sealed

*/

/* 2- Qual das palavras-chave a seguir é usada para alterar os dados e o comportamento de
uma classe base substituindo um membro de uma classe base por um novo membro
derivado ?
( ) new ( ) base ( ) overloads ( ) override ( ) overridable
Resposta: ( X ) override

*/

/* 3- Qual das seguintes afirmações está correta?
A( ) Os métodos estáticos podem ser um método virtual.
B( ) Os métodos abstratos não podem ser um método virtual.
C( ) É obrigatório substituir um método virtual.
D( ) Ao substituir um método virtual, os nomes e as assinaturas do método de substituição devem ser os
mesmos do método virtual que está sendo substituído.
E( ) Podemos substituir métodos virtuais e não virtuais.
Resposta: ( X ) D

*/

/* 4

B b = new B();
b.i = 1;
b.j = 2;
b.Exibir();
Console.ReadKey();

class A
{
public int i;
public void Exibir()
{
Console.WriteLine(i);
}
}
class B: A
{
public int j;
public void Exibir()
{
Console.WriteLine(j);
}
}

Qual o resultado da execução do código acima
considerando as classes A e B.
Onde B herda da classe A.
Reposta:
( ) 1
    2
( X ) 2
    (nenhum valor)
( ) 1
    (nenhum valor)
( ) Erro de compilação

*/

/* 
A a = new A();
B b = new B();
A x;
x = a;
x.Exibir();
x = b;
x.Exibir();

class A
{
public virtual void Exibir()
{
Console.WriteLine("A");
}
}
class B: A
{
public override void Exibir()
{
Console.WriteLine(" B ");
}
}
Qual o resultado da execução do código acima considerando as classes A e B, onde B herda da classe A ?
Resposta:
( X ) A
      B
( ) A
      A
( ) B
      B
( ) Erro de compilação

*/


/* Quais dos seguintes requisitos são necessários para o polimorfismo em tempo de execução?
1- O método base substituído deve ser virtual ou abstract
2- Tanto o método override quanto o método virtual devem ter o mesmo modificador de nível
de acesso.
3- Uma declaração override pode alterar a acessibilidade do método virtual.
4- Uma propriedade abstrata herdada não pode ser substituída em uma classe derivada.
5- Um método abstrato é implicitamente um método virtual.
( ) 1 e 3 ( ) 1, 2, e 5 ( ) 2, 3 e 4 ( ) somente 4
Resposta: ( X ) 1, 2, e 5


*/

/*
Crie um programa que implemente uma interface IVeiculo com dois métodos, um para Dirigir
do tipo void e outro para Abastecer do tipo bool que possui um parâmetro do tipo int com a
quantidade de gasolina a abastecer.(defina isso como uma propriedade)
Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a
quantidade inicial de gasolina do carro e implemente os métodos Dirigir e Abastecer do carro.
O método Dirigir deve exibir na tela ”Dirigindo o carro..”, se a gasolina for maior que 0, caso
contrário deve exibir “Sem gasolina...”, e o método Abastecer deve aumentar a gasolina do
carro e retornar true.
Para testar, crie um objeto do tipo Carro com 0 de gasolina inicial e solicite ao usuário a
informação de uma quantidade de gasolina para abastecer via teclado e por fim execute o
método Dirigir do carro.

*/
using System;

public interface IVeiculo
{
    void Dirigir();
    bool Abastecer(int quantidade);
}   
public class Carro : IVeiculo
{
    private int gasolina;

    public Carro(int quantidadeInicial)
    {
        gasolina = quantidadeInicial;
    }

    public void Dirigir()
    {
        if (gasolina > 0)
        {
            Console.WriteLine("Dirigindo o carro...");
            gasolina--; // Consome uma unidade de gasolina ao dirigir
        }
        else
        {
            Console.WriteLine("Sem gasolina...");
        }
    }

    public bool Abastecer(int quantidade)
    {
        gasolina += quantidade;
        return true;
    }
}   

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro(0);

        Console.Write("Digite a quantidade de gasolina para abastecer: ");
        int quantidade = int.Parse(Console.ReadLine());

        meuCarro.Abastecer(quantidade);
        meuCarro.Dirigir();

        Console.ReadKey();
    }
}   

/* Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação
orientada a objetos.
O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
construtor adicional, com o qual podemos especificar o número de páginas que queremos
no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
64 páginas.
Por fim, execute as seguintes ações:
- Criar um álbum de fotos padrão e exibir o número de páginas
- Criar um álbum de fotos com 24 páginas e exibir o número de páginas
- Criar um álbum de fotos grande e exibir o número de páginas
Para começar, crie uma classe chamada LivroFotos com um atributo privado numPaginas do
tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
páginas do álbum 



*/
class LivroFotos
{
    private int numPaginas;

    public LivroFotos()
    {
        numPaginas = 16; // Construtor padrão com 16 páginas
    }

    public LivroFotos(int paginas)
    {
        numPaginas = paginas; // Construtor com número especificado de páginas
    }

    public int GetNumeroPaginas()
    {
        return numPaginas;
    }
}
class SuperLivroFotos : LivroFotos
{
    public SuperLivroFotos() : base(64) // Construtor que cria um álbum com 64 páginas
    {
    }
}   
class TesteLivroFotos
{
    static void Main(string[] args)
    {
        LivroFotos albumPadrao = new LivroFotos();
        Console.WriteLine("Álbum padrão tem " + albumPadrao.GetNumeroPaginas() + " páginas.");

        LivroFotos albumPersonalizado = new LivroFotos(24);
        Console.WriteLine("Álbum personalizado tem " + albumPersonalizado.GetNumeroPaginas() + " páginas.");

        SuperLivroFotos albumGrande = new SuperLivroFotos();
        Console.WriteLine("Álbum grande tem " + albumGrande.GetNumeroPaginas() + " páginas.");

        Console.ReadKey();
    }
}   

/*
Crie um programa que solicite ao usuário três nomes de pessoas e os armazene em
uma matriz de objetos do tipo Pessoa. Haverá duas pessoas do tipo Aluno e uma
pessoa do tipo Professor.
Para isso, crie uma classe Pessoa que possua uma propriedade Nome do tipo string, um
construtor que receba o nome como parâmetro e sobrescreva o método ToString().
Então crie mais duas classes que herdam da classe Pessoa, elas serão chamadas de
Aluno e Professor. A classe Aluno possui um método Estudar que escreve pelo console
que o aluno está estudando. A classe Professor terá um método Explicar que grava no
console que o professor está explicando.
Lembre-se de também criar dois construtores nas classes filhas que chamam o
construtor pai da classe Pessoa.
Termine o programa lendo as pessoas (o professor e os alunos) e execute os métodos
Explicar e Estudar.


*/
class Pessoa
{
    public string Nome { get; set; }    
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public override string ToString()
    {   
        return "Nome: " + Nome;
    }
}
class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
    }
    public void Estudar()
    {
        Console.WriteLine(Nome + " está estudando.");
    }
}
class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    {
    }
    public void Explicar()
    {
        Console.WriteLine(Nome + " está explicando.");
    }
}
class TestePessoa
{
    static void Main(string[] args)
    {
        Pessoa[] pessoas = new Pessoa[3];   
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
            string nomeAluno = Console.ReadLine();
            pessoas[i] = new Aluno(nomeAluno);
        }
        Console.Write("Digite o nome do professor: ");
        string nomeProfessor = Console.ReadLine();
        pessoas[2] = new Professor(nomeProfessor);      
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa.ToString());
            if (pessoa is Aluno aluno)
            {
                aluno.Estudar();
            }
            else if (pessoa is Professor professor)
            {
                professor.Explicar();
            }
        }
        Console.ReadKey();
    }
}   

/* Crie um programa que solicite ao usuário os nomes de três pessoas e os armazene em uma
matriz de objetos do tipo Pessoa.
Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo
string, um construtor que receba o nome como parâmetro e sobrescreva o método
ToString().
Finalize o programa lendo as pessoas e executando o método ToString() na tela.


*/
class PessoaSimples
{
    public string Nome { get; set; }    
    public PessoaSimples(string nome)
    {
        Nome = nome;
    }
    public override string ToString()
    {   
        return "Nome: " + Nome;
    }
}
class TestePessoaSimples
{           
    static void Main(string[] args) 
    {
        PessoaSimples[] pessoas = new PessoaSimples[3];   
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o nome da pessoa " + (i + 1) + ": ");
            string nome = Console.ReadLine();
            pessoas[i] = new PessoaSimples(nome);
        }      
        foreach (PessoaSimples pessoa in pessoas)
        {
            Console.WriteLine(pessoa.ToString());
        }
        Console.ReadKey();
    }
}   

/*
Para este exercício temos :
1- A classe abstrata Database
2- A classe concreta SQLServer que herda da classe Database

abstract class Database
{
public virtual void Conectar()
{
Console.WriteLine("Conectando ao banco de dados...");
}
public abstract void Configurar();
}
Quais alterações podemos fazer para que ele possa chamar o método Conectar da classe SQL Server sem
alterar o código na classe Program (Método Main)

Resposta:
( X ) Tornar o método Conectar abstrato na classe Database e sobrescrevê-lo na classe SQLServer
( ) Tornar o método Configurar virtual na classe Database e sobrescrevê-lo na classe SQLServer
( ) Tornar a classe Database concreta
( ) Nenhuma das alternativas
*/


/*
B b = new B("Olá Mundo...");
b.Exibir();
Console.ReadKey();
class A
{
String texto;
public A(string s)
{
this.texto = s;
}
public void Exibir()
{
Console.Write(texto);
}
}
class B : A
{
public B(string s) : base(s)
{
Console.Write(s);
}
}
Dado o código ao lado explique qual vai ser o resultado da execução
deste código.

Resposta: O resultado da execução do código será a impressão de "Olá Mundo...Olá Mundo...".


*/


/*
INota1 p = new Exibir();
p.Classificacao();
Console.ReadKey();
interface INota1
{
void Classificacao();
}
interface INota2
{
void Classificacao();
}
class Exibir : INota1, INota2
{
public void Classificacao()
{
Console.WriteLine("Classificacao INota1");
}
public void Classificacao()
{
Console.WriteLine("Classificacao INota1");
}
}

Dado o código ao lado explique qual vai ser o resultado da
sua execução e o que deve ser feito para corrigir o código
caso isso seja necessário

Resposta: O código não compilará devido à ambiguidade na implementação do método Classificacao() para as duas interfaces 
INota1 e INota2. Para corrigir isso, devemos implementar explicitamente o método Classificacao() para cada interface, como mostrado abaixo:
class Exibir : INota1, INota2
{
    void INota1.Classificacao()
    {
        Console.WriteLine("Classificacao INota1");
    }
    void INota2.Classificacao()
    {
        Console.WriteLine("Classificacao INota2");
    }
}

*/

/* Na linguagem C# podemos criar um objeto da classe derivada a partir da sua classe base ?
Explique e de um exemplo de código.
Resposta: Sim, na linguagem C# podemos criar um objeto da classe derivada a partir da sua classe base usando o conceito 
de polimorfismo. Isso é feito declarando uma variável do tipo da classe base e atribuindo a ela uma instância da classe derivada. 
Por exemplo:
class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("Som de animal");
    }
}   
class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Latido");
    }
}   
class Program
{
    static void Main(string[] args)
    {
        Animal meuAnimal = new Cachorro(); // Criando um objeto da classe derivada Cachorro a partir da classe base Animal
        meuAnimal.FazerSom(); // Saída: Latido
        Console.ReadKey();
    }
}

*/

/*
Apresente um cenário onde a utilização de interfaces seria a única solução possível. Explique
e dê um exemplo de código.
Um cenário onde o uso de interfaces é a única solução possível seria um cenário onde temos que uma classe
precisa herdar de mais de uma classe ou interface, caracterizando a herança múltipla de interface.
Na linguagem C# uma classe não pode herdar de mais de uma classe porém pode herdar de várias interfaces.
Neste caso o uso de interfaces seria indispensável.

Resposta:
interface IVoar
{
    void Voar();
}
interface INadar
{   
    void Nadar();
}
class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando.");
    }
    public void Nadar() 
    {
        Console.WriteLine("O pato está nadando.");
    }
}   
Explicação: Neste exemplo, a classe Pato implementa duas interfaces, IVoar e INadar, permitindo que um objeto do tipo Pato possa
voar e nadar. Se tentássemos usar classes base em vez de interfaces, não seria possível, pois C# não suporta herança múltipla 
de classes.


*/  


/*
Usando os conceitos de polimorfismo escreva um programa para calcular a área do
Quadrado, Triângulo e do Circulo
Fórmulas das áreas
- Quadrado -> A = lado * lado
- Triângulo -> A = (base * altura)/2
- Circulo -> A = Pi * raio * raio ou A = π . r²


*/
abstract class Forma
{
    public abstract double CalcularArea();
}
class Quadrado : Forma
{
    public double Lado { get; set; }
    public Quadrado(double lado)
    {
        Lado = lado;
    }
    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}
class Triangulo : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public Triangulo(double b, double a)
    {
        Base = b;
        Altura = a;
    }
    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}
class Circulo : Forma
{
    public double Raio { get; set; }
    public Circulo(double r)
    {
        Raio = r;
    }
    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}
class TesteFormas
{   
    static void Main(string[] args)
    {
        Forma quadrado = new Quadrado(4);
        Forma triangulo = new Triangulo(3, 5);
        Forma circulo = new Circulo(2);

        Console.WriteLine("Área do Quadrado: " + quadrado.CalcularArea());
        Console.WriteLine("Área do Triângulo: " + triangulo.CalcularArea());
        Console.WriteLine("Área do Círculo: " + circulo.CalcularArea());

        Console.ReadKey();
    }
}       

