/* Precedência e Associatividade em C#
Regras
A precedência determina a ordem em que os operadores são avaliados em expressões.
No C#, cada operador tem um nível de precedência associado.

As expressões com operadores de maior precedência são avaliadas primeira.

Quando dois operadores têm a mesma precedência, a associatividade é usada para determinar a ordem de avaliação.
A associatividade determina a ordem em que os operadores do mesmo nível de precedência são avaliados

Tabela de precedência e associatividade dos operadores
Operadores      Ordem decrescente de Precedência   Associatividade
Aritméticos      *,/,%,+-                           Esquerda para direita
Atribuição      =,+=,-=,*=,/=,%=                    Direita para esquerda        
Incremento/Decremento ++,--                     Direita para esquerda
Relacionais     <,>,<=,>=,==,!=                     Esquerda para direita
Lógicos         &&,||                               Esquerda para direita

Os operadores [] e () têm a mais alta precedência, nessa ordem, 
podem ser usados para alterar a ordem de precedência.

Exemplo:
int x= 10 -2 *3;
=> 2*3 =6
=> 10 -6 =4

Neste exemplo, a multiplicação (*) tem maior precedência que a 
subtração (-),
então a expressão é avaliada como 10 - (2 * 3), resultando  em 4.

*/
Console.WriteLine("Precedência e Associatividade em C#");

int x = 10 - 2 * 3;
Console.WriteLine(x);

//Alterando usando ()
x = (10 - 2) * 3;
Console.WriteLine(x);


//Ordem de precedência: !, %% e ||

bool b = !(9 != 8) && 5 >= 7 || 8 >=6;
//false && false || true
//false || true
//true

Console.WriteLine(b);

//Alterando a ordem de precedência usando ()
bool b = !(9 != 8) && (5 >= 7 || 8 >=6);
//!(true) && (false || true)
//false && true
//false


bool b = !(9 != 8) && (5 >= 7 || 8 >=6);


/*Tabela geral de precedência e associatividade dos operadores em C#
https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/

*/

/* Ordem de precedência
++(prefixo), --(prefixo), * e -
*/

int a=5, b=6, c=4;
int r= --a * b - ++c;

/*
int r=((--a) * b) - (++c);
=> --5 * 6 - ++4
=> 4 * 6 - 5
=> 24 - 5
*/
Console.WriteLine(r);


/* Precedência e associatividade

int a=5, b=6, c=4;
int resultado= a = b = c;

A associatividade do operador = é da direita para a esquerda.


=> a = b = 3
=> a = 3
=> 3 -> resultado = 3

*/
Console.Readkey();
