Console.WriteLine("Operadores de atribuição em C#");

/*
= ex: x=10. x recebe o valor 10
+= ex: x+=5. x recebe o valor de x mais 5 (x = x + 5)
-= ex: x-=3. x recebe o valor de x menos 3 (x = x - 3)
*= ex: x*=2. x recebe o valor de x vezes 2 (x = x * 2)
/= ex: x/=4. x recebe o valor de x dividido por 4 (x = x / 4)
%= ex: x%=3. x recebe o valor do resto da divisão de x por 3 (x = x % 3)

*/


//Usando operadores de atribuição com tipos numéricos
var x = 10;
Console.WriteLine($"Valor inicial de x: {x}");
Console.WriteLine($"x+=5 => {x+=5}"); // x = x + 5
Console.WriteLine($"x-=3 => {x-=3}"); // x = x - 3
Console.WriteLine($"x*=4 => {x*=4}"); // x = x * 2
Console.WriteLine($"x/=5 => {x/=5}"); // x = x / 4
Console.WriteLine($"x%=5 => {x%=3}"); // x = x % 3



//Operador + e += com strings
/*
string y= "123"; valor inicial de y é "123"
y += "456"; agora o valor de y é "123456"
*/
var y = "123";
Console.WriteLine($"\nValor inicial de y: {y}");
Console.WriteLine($"y += \"456\" => {y += "456"}");

Console.ReadKey();