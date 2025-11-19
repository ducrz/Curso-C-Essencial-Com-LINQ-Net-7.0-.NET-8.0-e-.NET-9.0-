Console.WriteLine("Struct DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data atual: " + dataAtual);

//Criar uma data específica usando formato: aaaa, mm, dd
DateTime dataEspecifica = new DateTime(2025, 11, 19);

//Definir as horas
DateTime dataHoraHoje = new DateTime(2025, 11, 19, 09, 36, 0);

Console.WriteLine(dataHoraHoje);

//Extrair Informações da data atual
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.milisecond);

//Adicionando valores
Console.WriteLine(hoje.AddHours(5));
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddYears(5));

//Exibindo Hoje2
DateTime hoje2 = DateTime.Now;
COnsole.WriteLine($"hoje2: {hoje2}\n");

//Obter o dia da semana e do ano
System.Console.WriteLine(hoje2.DayOfWeek);
System.Console.WriteLine(hoje2.DayOfYear);

//Data no Formato Longo e Curto
System.Console.WriteLine(hoje2.ToLongDateString());
System.Console.WriteLine(hoje2.ToShortDateString());

System.Console.WriteLine(hoje2.ToLongTimeString());
System.Console.WriteLine(hoje2.ToShortTimeString());



cw.readKey();
