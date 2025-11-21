/* Operadores Lógicos em C# 
São eles:
&& (AND- E lógico)
|| (OR- OU lógico)
! (NOT - NÃO lógico)  

Tabela verdade de cada operador:
AND (&&)
A     B     A && B
V     V       V
V     F       F
F     V       F
F     F       F         
OR (||)
A     B     A || B
V     V       V   
V     F       V
F     V       V
F     F       F 

NOT (!)
A     !A
V     F
F     V   


*/

Console.WriteLine("Operadores Lógicos em C#");

bool c1= 5 >=7;
bool c2= 9 != 8;
bool resultado;

Console.WriteLine($"c1: {c1}");
Console.WriteLine($"c2: {c2}\n");

//operador AND (&&)    
resultado= c1 && c2;
Console.WriteLine("Operador AND (&&) :"+resultado);


//Operador OR (||) 
resultado= c1 || c2;
Console.WriteLine("Operador OR (||) :"+resultado);

//Operador NOT (!)
resultado= !c1;
Console.WriteLine("Operador NOT (!):"+resultado);


Console.ReadKey();