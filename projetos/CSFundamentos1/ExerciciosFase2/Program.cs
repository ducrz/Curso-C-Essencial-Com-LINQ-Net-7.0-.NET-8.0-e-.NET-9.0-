Console.WriteLine("Exercícios fase 2 - Fundamentos de C#");


/* 1- Declare as variáveis nome, idade e nota atribuindo os valores 
“Paulo”, 17 e 7.5 e exiba a saída no formato :
Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.
*/
string nome = "Paulo";
int idade = 17;
double nota = 7.5; 
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
Console.ReadKey();

/* 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
escapes.
*/
Console.WriteLine("Aluno\n" + nome + "\ntem\n" + idade + "\nanos e nota\n" + nota);
Console.WriteLine($"Aluno\n{nome}\ntem\n{idade}\nanos e nota\n{nota}");

Console.ReadKey();

/* Exercícios fase 2
3- Para qual tipo de dados você pode converter um float implicitamente ?
( ) int
(X) double
( ) long
( ) decimal

Resposta: double

*/

/*4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
( ) int para long
( ) double para long
(x) double para float
( ) decimal para float
(x) long para int
(x) double para decimal

Resposta: double para float, long para int, double para decimal.
*/

/* 5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
a concatenação e também a interpolação de strings

*/
Console.WriteLine("Digite a primeira letra:");
char letra1 = Console.ReadLine()[0];
Console.WriteLine("Digite a segunda letra:");
char letra2 = Console.ReadLine()[0];
Console.WriteLine("Digite a terceira letra:");
char letra3 = Console.ReadLine()[0];
Console.WriteLine("Ordem reversa (concatenação): " + letra3 + letra2 + letra1);
Console.WriteLine($"Ordem reversa (interpolação): {letra3}{letra2}{letra1}");
Console.ReadKey();

/* 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
( ) long resultado = 1.32;
( ) var nome = “Maria”;
( ) string resultado = 100.ToString();
( ) A sequência de escape \n inclui uma nova linha
( ) float f = 5.45;
( ) decimal valor = (decimal) 10.99f;
( ) var status = null;
( ) object o = 12.45m;
( ) string titulo = true.ToString();
( ) A sequencia \t inclui uma tabulação vertical
Resposta: 
(F) long resultado = 1.32; (tipo incompatível)
(V) var nome = “Maria”;
(V) string resultado = 100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(F) float f = 5.45; (é necessário o sufixo f: 5.45f)
(V) decimal valor = (decimal) 10.99f;
(F) var status = null; (não é possível inferir o tipo)
(V) object o = 12.45m;
(V) string titulo = true.ToString();
(F) A sequencia \t inclui uma tabulação vertical (é uma tabulação horizontal)

*/

/*
7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
exibindo o resultado:
*/
Console.WriteLine("Digite o primeiro valor:");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
double valor2 = Convert.ToDouble(Console.ReadLine());
double soma = valor1 + valor2;
double subtracao = valor1 - valor2;
double multiplicacao = valor1 * valor2;
double divisao = valor1 / valor2;
double modulo = valor1 % valor2;
double exponenciacao = Math.Pow(valor1, valor2);
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Módulo: {modulo}");
Console.WriteLine($"Exponenciação: {exponenciacao}");
Console.ReadKey();

/* 8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
a b e c .
Valores: a=1, b=12 e c=-13.

*/
double a = 1;
double b = 12;
double c = -13;
double delta = b * b - 4 * a * c;
if (delta < 0)      
{
    Console.WriteLine("Não existem raízes reais.");
}
else
{
    double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"As raízes são: {raiz1} e {raiz2}");
}
Console.ReadKey();  

/* 9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
inválido’: (use o operador condicional ternário)

*/
Console.WriteLine("Digite o nome:");
string usuario = Console.ReadLine();
Console.WriteLine("Digite a senha:");
int senha = Convert.ToInt32(Console.ReadLine());
string mensagem = ( (usuario == "admin" || usuario == "maria") && senha == 123 ) ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(mensagem);
Console.ReadKey();


/* 10
10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
a nomenclatura usada:
(V) string? nome; é um exemplo de nullable reference type;
(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
(F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
(F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
(F) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"
*/

/*11
11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
*/

Console.Write("Digite o valor de x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de y: ");
int y = int.Parse(Console.ReadLine());

string resultadoX = (x % 2 == 0) ? "x é par" : "x é ímpar";
string resultadoY = (y % 2 == 0) ? "y é par" : "y é ímpar";

Console.WriteLine(resultadoX);
Console.WriteLine(resultadoY);

Console.ReadKey();


/*12
12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)
-6 + x * 5
(13-2) * x
(x + -2) * (20 / x)
(12 + x) / (x - 4)
3 x^2 + x + 10
pi * x^2
*/

Console.Write("Digite um número inteiro x: ");
int x = int.Parse(Console.ReadLine());

double pi = 3.1415;

double op1 = -6 + x * 5;
double op2 = (13 - 2) * x;
double op3 = (x + -2) * (20.0 / x);
double op4 = (12.0 + x) / (x - 4);
double op5 = 3 * Math.Pow(x, 2) + x + 10;
double op6 = pi * Math.Pow(x, 2);

Console.WriteLine("-6 + x * 5 = " + op1);
Console.WriteLine("(13 - 2) * x = " + op2);
Console.WriteLine("(x + -2) * (20 / x) = " + op3);
Console.WriteLine("(12 + x) / (x - 4) = " + op4);
Console.WriteLine("3x^2 + x + 10 = " + op5);
Console.WriteLine("pi * x^2 = " + op6);


/*13
13- Considere o seguinte trecho de código:
int y = 5 ;
y = (y++)+y+(++y); ou y = y++ + y + ++y;
Console.WriteLine(y);

Resposta: 
y = 5
y++ + y + ++y

y++

Retorna 5

Depois incrementa y para 6

y

Agora y vale 6

Retorna 6

++y

Primeiro incrementa: y = 7

Depois retorna 7

5 + 6 + 7 = 18

*/

/*14

14- Escreva um programa que solicite a temperatura em graus Celsius e converta para
Kelvin e Farhenheit usando as fórmulas a seguir:
- Converter para Kelvin => K = C + 273 ;
- Converter para Farhenheit => F = (C * 9) / 5 + 32 ;

*/

Console.Write("Digite a temperatura em graus Celsius: ");
double c = double.Parse(Console.ReadLine());

double kelvin = c + 273;
double fahrenheit = (c * 9) / 5 + 32;

Console.WriteLine("Temperatura em Kelvin: " + kelvin);
Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);

Console.ReadKey();


/* 15
15 - Escolha a opção que representa a exibição do resultado para o código usando os
operadores de decremento e incremento (pré e pós) :

var numero = 5;
Console.WriteLine(numero++);
numero = 1;
Console.WriteLine(++numero);
numero = 2;
Console.WriteLine(numero--);
numero = 3;
Console.WriteLine(--numero);
Console.ReadKey();

Resposta: 
5
2
2
2

*/

var numero = 5;
Console.WriteLine(numero++);
numero = 1;
Console.WriteLine(++numero);
numero = 2;
Console.WriteLine(numero--);
numero = 3;
Console.WriteLine(--numero);
Console.ReadKey();