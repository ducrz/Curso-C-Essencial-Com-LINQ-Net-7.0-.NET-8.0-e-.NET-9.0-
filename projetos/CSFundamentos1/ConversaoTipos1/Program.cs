Console.WriteLine("Conversão de Tipos em C#! \n");

int varInt = 100;
double varDouble= varInt; // Conversão implícita de int para double
Console.WriteLine("Valor da variável double (conversão implícita): " + varDouble);

//byte - 1 byte
//short - 2 bytes
//int - 4 bytes
//long - 8 bytes
//float - 4 bytes
//double - 8 bytes
//decimal - 16 bytes    


int numeroInt = 2145678;
long numeroIntLong = numeroInt; // Conversão implícita de int para long
float numeroFloat = numeroInt; // Conversão implícita de int para float
double numeroDouble = numeroInt; // Conversão implícita de int para double
decimal numeroDecimal = numeroInt; // Conversão implícita de int para decimal

Console.Writeline(numeroInt);
Console.Writeline(numeroIntLong);
Console.Writeline(numeroFloat);
Console.Writeline(numeroDouble);
Console.Writeline(numeroDecimal);

//Tipos de conversões implícitas possíveis em C#
//sbyte -> short -> int -> long -> float -> double -> decimal
//byte -> short -> int -> long -> float -> double -> decimal
//short -> int -> long -> float -> double -> decimal
//ushort -> int -> long -> float -> double -> decimal
//int -> long -> float -> double -> decimal
//uint -> long -> float -> double -> decimal
//long -> float -> double -> decimal
//char -> ushort -> int -> long -> float -> double -> decimal   
//float -> double
//nint -> long -> float -> double -> decimal
//nuint -> ulong -> float -> double -> decimal

Console.WriteLine("\nConversão explícita de tipos em C#! \n");
double varDouble = 12.456;
//int varInt= varDouble; // Erro de compilação: conversão explícita necessária
int varInt = (int)varDouble; // Conversão explícita de double para int

Console.WriteLine(varInt);

int num1=10;
int num2=4;

float resultado = (float)num1/num2; // Divisão entre inteiros resulta em inteiro

Console.WriteLine(resultado);

