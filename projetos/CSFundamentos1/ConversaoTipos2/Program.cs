Console.WriteLine("Conversão de tipos em C#");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1= valorInt;
string s2= valorDouble.ToString();
string s3= valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);


//Conversão de tipos usando a classe Convert
//ToBoolean() - converte um tipo para boolean
//ToChar() - converte um tipo para char
//ToDouble() - converte um tipo para double
//ToInt16() - converte um tipo para short
//ToInt32() - converte um tipo para int

//ToInt64() - converte um tipo para long
//ToString() - converte um tipo para string
int valorInt=10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

int varInt= 100000;
Console.WriteLine(Convert.ToByte(varInt));


Console.ReadLine();
