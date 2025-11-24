/* 

Programação Orientada a Objetos (POO)

Classes e Métodos em C#

Classe

É um tipo estruturado que contém membros:

1. Atributos (dados: propriedades, campos)
2. Comportamentos (métodos)


Classe é uma abstração de uma entidade do mundo real.
Exemplo: Pessoa

Atributos: Nome, Idade, Altura, Sexo
Comportamentos: Comer, Caminhar, Trabalhar

class Pessoa{
    // Atributos
    public string Nome;
    public int Idade;
    public float Altura;
    public char Sexo;

    // Métodos
    public void Comer(){
        // Implementação do método Comer
    }

    public void Caminhar(){
        // Implementação do método Caminhar
    }

    public void Trabalhar(){
        // Implementação do método Trabalhar
    }
}

Uma classe pode ser entendida como um modeloo ou um template, que
contém valores conhecidos como membro de dados e conjunto de regras,
conhecidos como comportamentos ou métodos.

Pessoa agora representa um tipo que contém atributos e comportamentos.

A classe Pessoa agora pode criar objetos da tipo Pessoa.

Para criar objetos a partir de uma classe, usamos o operador "new".
*/
Console.WriteLine("Classes e Métodos em C#");
/*
int x = 100;

Pessoa p1= new Pessoa();
p1.Nome = "Eduardo ";
p1.Idade = 36;
p1.Sexo = 'M';

class Pessoa{
    // Atributos
    public string Nome;
    public int Idade;
    public char Sexo;

    // Métodos
 public void Comer(){
        Console.WriteLine($"{Nome} está comendo.");
    }

    public void Respirar(){
        Console.WriteLine($"{Nome} está respirando.");
}
}
*/

int x=100;
Pessoa p1 = new Pessoa();
p1.nome = "Eduardo";
p1.idade = 36;
p1.sexo = "Masculino";  
Console.WriteLine($"Nome: {p1.nome} {p1.idade} anos Sexo: {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.nome = "Maria";
p2.idade = 30;
p2.sexo = "Feminino";
Console.WriteLine($"Nome: {p2.nome} {p2.idade} anos Sexo: {p2.sexo}");


Console.ReadKey();
class Pessoa
{
    public string? nome;
    public int idade;
    public string sexo;
}

/* Objeto
Um objeto é uma instância de uma classe, criado pelo operador "new",
todos os membros da classe podem ser acessados através do objeto.

public class Cachorro{
    public string nome;
    public int cor;
    public string sexo;
    
    public void Comer();
    public void Latir();
}

Cachorro bilu = new Cachorro();
bilu.nome = "Bilu";
bilu.cor = "Marrom";
bilu.sexo = "Macho";

Cachorro pipoca = new Cachorro();
pipoca.nome = "Pipoca";
pipoca.cor = "Branco com pintas"";
pipoca.sexo = "macho";

Classe  vs Objeto

Os objetos possuem características próprias, definidas pelos atributos e podem
ser categorizados, agrupados, enquanto que uma classe descreve todos os objetos
de um tipo particular.

A classe é um modelo, um planejamento, tal como a maquete de uma casa.
O objeto seria a classe materializada, ou seja, um objeto com os devidos 
atributos qualificados: uma casa azul, térra, com garagem, construída em 2025,
com valor de mercado de R$ 350.000,00, com área de 250 m².

Pessoa p1 = new(); //A partir do C# 10.

*/

/* Métodos

Os métodos representam os comportamentos das classes e são usados
para executar ações e realizar a comunicação entre os objetos das classes.

Um método é um bloco de código que contém uma série de instruções
que são executadas quando o método é chamado.

No C#, todas as instruções executadas são realizadas no contexto de um método.,
todos os métodos são definidos em classes.

O método Main é o ponto de entrada de um programa C# e é chamado pela CLR
(Common Language Runtime) quando o programa é iniciado.

*/

