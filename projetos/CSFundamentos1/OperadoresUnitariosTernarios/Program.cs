/* Operadores Unitário e Ternário em C#
Unitário (+) e (-)
Ternário ( ? : )

Os operadores unitários atuam em um operando em uma expressão.
++, --, !, +, -

Os operadores binários atuam em dois operandos em uma expressão.
&&, ||, !=, >, <, >=, <=, *=, /=, %=, +=, -=, ==, =, *, +, -, /, %

O operador ternário utiliza 3 argumentos e avalia uma expressão booleana.
?:
 */

Console.WriteLine("Operadores Unitário e Ternário em C#");


int positivo =1;
int resultado;

resultado = +positivo; // Operador unitário +   
Console.WriteLine("Operador unitário + : " + resultado);


Console.WriteLine("Informe o número: \n");
var n =Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é: " + -n); // Operador unitário -


//Operador condicional Ternário (? :)
//Expressão booleana ? valor se verdadeiro : valor se falso

Console.WriteLine("Informe a temperatura: \n");
var temp =Convert.ToDouble(Console.ReadLine());
var resultado = temp > 27 ? "Quente" : "Normal"; // Operador ternário

Console.WriteLine($"A temperatura está: {resultado}");


Console.WriteLine("---------------");
Console.WriteLine("Informe o valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());

string resultado = a > b ? "a é maior que b" :
                    a < b ? "a é menor que b" :
                    a ==b ? "a é igual a b" : "Nehum resultado";

Console.WriteLine(resultado);

Console.ReadKey();