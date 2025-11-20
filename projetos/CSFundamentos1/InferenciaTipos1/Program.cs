//Inferência de tipos em C#

/*A linguagem C# é fortemente tipada e a declaração de tipo padrão é o tipo explícito.

string nome = "Maria";
int idade = 10;

Inferência de tipos- palarva chave var

int x = 0; Definição explícita ou direta do tipo de dados da variável x;

var x = 0; Definição implícita ou indireta do tipo de dados da variável x;

Erro: var x; As variáveis tipadas implicitamente, precisam ser inicializadas.
*/


Console.WriteLine("Inferência de tipos em C#");

int idade = 25;               // Declaração explícita
string nome = "Maria";
decimal salario = 15000.00m;

Console.WriteLine  ($"Nome: {nome}, Idade: {idade}, Salário: {salario.ToString("C")}");


//Declaração implícita usando var
var idade2 = 30;
var nome2 = "João";
var salario2 = 20000.00m;   

Console.WriteLine  ($"Nome: {nome2}, Idade: {idade2}, Salário: {salario2.ToString("C")}");


//Limitações do var
//var valor; // Erro: Variável não inicializada

//não pode ser null
//var valor = null; // Erro: Não pode inferir o tipo

//não pode mudar o tipo após inicilizar
//var valor = 10;
//valor = "Texto"; // Erro: Não pode mudar o tipo

//var funciona também para tipos definidos pelo usuário
var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Dentro do método MeuMetodo da classe Teste");
    }
}

//Usos da palavra chave var
/*
Considerado um açucar sintático (sugar sintax)
Usada para declarar tipos anônimos
Usada em laços for e foreach
Usada em instruções using
*/