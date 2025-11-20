/* Operadores Incrementais e Decrementais
Aumentam ou diminuem o valor de uma variável em 1.
Operador de incremento: ++
    pré-increemento: ++variável (incrementa antes de usar o valor)
    pós-incremento: variável++ (usa o valor antes de incrementar)

Operador de decremento: --
    pré-decremento: --variável (decrementa antes de usar o valor)
    pós-decremento: variável-- (usa o valor antes de decrementar)
*/

Console.WriteLine("Operadores de Incremento e Decremento em C#");

int x = 10;
x++; // Incrementa x em 1 (x = x + 1)
Console.WriteLine("Valor de x após incremento: " + x);

x--; // Decrementa x em 1 (x = x - 1)
Console.WriteLine("Valor de x após decremento: " + x);

//Pós-incremento

int x1=0;
Console.WriteLine("Valor de x1: " + x1);
int resultado1= x++ +10;
Console.WriteLine($"Resultado do pós-incremento (x++ + 10): {resultado1}");
Console.WriteLine("Valor de x1 após pós-incremento: " + x1);


//Pré-incremento
int x2=0;
Console.WriteLine("Valor de x2: " + x2);
int resultado2= ++x2 +10;
Console.WriteLine($"Resultado do pré-incremento (++x + 10): {resultado2}");
Console.WriteLine("Valor de x2 após pré-incremento: " + x2);

//Pré-decremento
int x3=0;
Console.WriteLine("Valor de x3: " + x3);
int resultado3= --x3 +10;
Console.WriteLine($"Resultado do pré-decremento (--x + 10): {resultado3}");
Console.WriteLine("Valor de x3 após pré-decremento: " + x3);        

//Pós-decremento
int x4=0;
Console.WriteLine("Valor de x4: " + x4);
int resultado4= x4-- +10;
Console.WriteLine($"Resultado do pós-decremento (x-- + 10): {resultado4}");
Console.WriteLine("Valor de x4 após pós-decremento: " + x4);


Console.ReadKey();

