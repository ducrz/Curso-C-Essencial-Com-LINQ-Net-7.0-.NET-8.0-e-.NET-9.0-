Console.WriteLine("Nullable Types in C#");

Nullable<int> i= null;
Nullable<double> d= null;
Nullable<bool> b= null;

Console.WriteLine($"Nullable int: {i}");
Console.WriteLine($"Nullable double: {d}");
Console.WriteLine($"Nullable bool: {b}");


//Simplificando a declaração com o operador '?'
int? x= null;
double? y= null;
bool? z= null;  

console.WriteLine($"Nullable int with ?: {x}");
Console.WriteLine($"Nullable double with ?: {y}");
Console.WriteLine($"Nullable bool with ?: {z}");


int? a= null;
int b = a ?? 0; // Se 'a' for null, atribui 0 a 'b'
Console.WriteLine($"Value of b when a is null: {b}");


int? c= 4;
int e = 3;
int z= c *e;

Console.WriteLine($"Value of z when c is 4 and e is 3: {z}");


int? b = null;

if (b.HasValue)
{
    Console.WriteLine($"b has value: {b.Value}");
}
else
{
    Console.WriteLine("b is null");
}

Console.readKey();


