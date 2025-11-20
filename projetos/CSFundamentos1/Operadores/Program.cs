Console.WriteLine("Operadores Aritméticos: em C#");

//Operadores Binários
//Adição, operador +. Exemplo: x+y
//subtração, operador -. Exemplo: x-y
//multiplicação, operador *. Exemplo: x*y
//divisão, operador /. Exemplo: x/y
//módulo, operador %. Exemplo: x%y

Console.WriteLine("Informe o valor de x");
int x= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma: {x+y}");
Console.WriteLine($"Subtração: {x-y}");
Console.WriteLine($"Multiplicação: {x*y}");
double divisao = (double) x /y;

Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Módulo: {x%y}");


Console.ReadKey();



//Classe Math
//A classe Math fornece métodos e constantes para realizar operações matemáticas comuns em C#.
//Math.PI: Representa o valor de π (pi).
//Math.E: Representa a base do logaritmo natural (e).
//Cos(x): Retorna o cosseno de x (em radianos).
//Sin(x): Retorna o seno de x (em radianos).
//Tan(x): Retorna a tangente de x (em radianos).
//sqrt(x): Retorna a raiz quadrada de x.
//Pow(x, y): Retorna o valor de x elevado à potência y.
//Abs(x): Retorna o valor absoluto de x.
//Max(x, y): Retorna o maior valor entre x e y.
//Min(x, y): Retorna o menor valor entre x e y.
//Log10(x): Retorna o logaritmo base 10 de x.
//Log(x): Retorna o logaritmo natural de x.
//Exp(x): Retorna e elevado à potência x.

Console.WriteLine("Informe o valor de x2");
int x2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y2");
int y2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nOperadores da Classe Math:");
console.WriteLine($"Raiz quadrada de x2: {sqrt(x2)}");
Console.WriteLine($"Potência de x2 elevado a y2: {Pow(x2, y2)}");
Console.WriteLine($"Valor mínimo entre x2 e y2: {Min(x2, y2)}");
Console.WriteLine($"Valor máximo entre x2 e y2: {Max(x2, y2)}");
Console.WriteLine($"Coseno de x2: {Cos(x2)}");
Console.WriteLine($"Seno de x2: {Sin(x2)}");
Console.WriteLine($"Exponencial de x2: {Exp(x2)}");


Console.ReadKey();
