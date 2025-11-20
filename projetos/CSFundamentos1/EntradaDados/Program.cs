Console.WriteLine("Entrada de dados em C#");

Console.Write("\nDigite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("\nO seu nome é: " + nome);

Console.WriteLine($"\nOlá, {nome}! Seja bem-vindo(a) ao mundo de C#!");

Console.WriteLine("\nInforme a sua idade:   ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nSua idade é: " + idade + " anos.");

Console.WriteLine($"\nVocê tem {idade} anos de idade.");

Console.ReadKey();

