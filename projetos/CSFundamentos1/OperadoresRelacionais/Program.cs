/* Operadores Relacionais em C#

A características dos operadores relacionais em C# indicam que o resultado
de uma operação relacional é sempre um valor booleano (true ou false).
== -> igualdade
!= -> diferente
>  -> maior que
<  -> menor que
>= -> maior ou igual a
<= -> menor ou igual a 
Exemplo: int x=10 e int y=20
x == y -> false
x != y -> true
x > y  -> false
x < y  -> true
x >= y -> false
x <= y -> true  
*/

Console.WriteLine("Operadores Relacionais em C#\n");


int x = 10;
int y = 20;

Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y + "\n");

Console.WriteLine(x == y);  // false
bool resultado = x == y;
Console.WriteLine("Resultado de x == y: " + resultado + "\n");

Console.WriteLine(x == y);  // false
Console.WriteLine(x > y);   // false
Console.WriteLine(x < y);   // true
Console.WriteLine(x >= y);  // false
Console.WriteLine(x <= y);  // true
Console.WriteLine(x != y);  // true

Console.WriteLine("\nComparação de strings:");

string a ="Curso";
string b ="curso";

Console.WriteLine($"Valor de a: {a}");
Console.WriteLine($"Valor de b: {b}\n");

Console.WriteLine(a == b);  // false
Console.WriteLine(a.Equals(b));  // false

Console.ReadKey();