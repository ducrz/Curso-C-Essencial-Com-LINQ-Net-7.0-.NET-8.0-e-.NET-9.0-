//Exercícios fase 1
//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor
int idade = 35;
Console.WriteLine(idade);

//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor
string nome = "Maria";
Console.WriteLine(nome);

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine(altura);

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 9, 4);
Console.WriteLine(data.ToString("dd/MM/yyyy"));

//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ANO = 12;
Console.WriteLine(ANO);

//6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o
//valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine(nota);

//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?
//Os tipos por valor armazenam diretamente os dados na memória stack, enquanto tipos por referência armazenam um ponteiro para os dados que estão na memória heap. Tipos por valor incluem tipos primitivos como int, double, bool, etc., enquanto tipos por referência incluem classes, arrays e strings. Alterações em tipos por valor não afetam a variável original, enquanto alterações em tipos por referência podem afetar o objeto original.

//8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//(int) x = 10;

//(double) numero = 7.99;

//(char) letra = 'C';

//(float) temperatura = 27.4f;

//(bool) ativo = false;

//(string) nome = "Eduardo";

//(decimal) salario = 950.99m;

//(date) hoje = DateTime.Now;

//9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :

//(V) int n = 1;
//(R) string titulo = "A vida";
//(V) float f = 12.45f;
//(V) double d = 5.45;
//(V) decimal valor = 10.99m;
//(V) char sexo = ‘M’;
//(R) object o = null;

/* Tipos por Valor (V): Armazenam o valor real diretamente na variável (na Stack). Ao atribuir a uma nova variável, o valor é copiado. 
Isso inclui todos os tipos numéricos (int, float, double, decimal), char, bool e structs.

Tipos por Referência (R): Armazenam a referência (o endereço de memória) do objeto na variável (na Stack), enquanto o objeto real está na Heap. Ao atribuir a uma nova variável, a referência é copiada, e ambas as variáveis apontam para o mesmo objeto. 
Isso inclui string, object, class e arrays. */

//10- O que é um nullable type e qual a sua utilidade?

//Um Nullable Type (Tipo Anulável) é um recurso que permite que tipos de valor (como int, bool, float, DateTime, etc.) aceitem o valor null, além de seus valores normais.

int? idade = null;
double? peso = 75.5;


//11- O que é Camel Case ? Dê um exemplo de sua aplicação.

/*Camel Case é uma convenção de nomenclatura onde: A primeira letra da primeira palavra é sempre minúscula e a primeira letra de cada palavra subsequente é maiúscula.

O nome "Camel Case" vem da aparência que as maiúsculas no meio da palavra dão, lembrando as corcovas de um camelo. */

int contadorSemanas = 4;





// 12- O que é Pascal Case ? Dê um exemplo de sua aplicação.

/* Pascal Case (também conhecida como Upper Camel Case) é uma convenção de nomenclatura onde:
    A primeira letra de todas as palavras, incluindo a primeira, é maiúscula.
    Não há espaços. */
    
//    public class PessoaJuridica
//{
//    public string NomeEmpresa { get; set; }
//}

/* 13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
operação de soma) */
int x = 77;
int y = 66;
int soma = x + y;
Console.WriteLine("A soma de x e y é: " + soma);

//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
/* Os valores padrão dos tipos de dados em C# são:
bool: false
char: '\0' (caractere nulo)
int: 0
double: 0.0
float: 0.0f
decimal: 0.0m
string: null */ 


/* 15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:

(F) double 1valor = 12.45; Não pode começar com número
(F) int total#de#alunos = 30; Não pode conter caracteres especiais como #
(F) char letra = 'AB'; Deve ser apenas um caractere 
(F) string #nome = "Pedro";  Não pode começar com caractere especial
(V) float _temperatura = 12.45f; Pode começar com _ (sublinhado)
(F) double int = 5;  Não pode usar palavra reservada
(V) decimal renda extra = 91.45m;    Pode usar espaço, mas não é recomendado
(F) bool status$conta = false;   Não pode conter caracteres especiais como $
(V) string titulo3 = “Tópico 1”; Pode conter números desde que não seja o primeiro caractere
(V) float salario_mensal = 1999.55f; Pode usar _ (sublinhado)
(V) int percentualValorDesconto = 5;     Pode usar palavras compostas
(V) const bool MENSALIDADE_EM_DIA = true;    Pode usar maiúsculas e _

*/