Console.WriteLine("Saída de dados: Formatação básica");

int idade = 25;
string nome = "Maria";

System.Console.WriteLine(idade);
System.Console.WriteLine(nome);
Console.WriteLine();

//Escreva na mesma linha "Maria tem 25 anos"

//1ª forma
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos.");
Console.WriteLine();

//2ª forma: usar concatenação : usando o operador +
System.Console.WriteLine(nome + " tem " + idade + " anos.");
System.Console.Write(nome + " tem " + idade + " anos.");

Console.WriteLine();


//3ª forma - interpolação de strings
System.Console.WriteLine(nome + " tem " + idade + " anos.");
Console.WriteLine();

System.Console.WriteLine($"{nome} tem {idade} anos.");

//usando placeholder: usa {} com numeração iniciando em 0
System.Console.WriteLine("{0} tem {1} anos.", nome, idade);



Console.ReadLine();