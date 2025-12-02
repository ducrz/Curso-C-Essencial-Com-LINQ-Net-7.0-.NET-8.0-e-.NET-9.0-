/* Exercicio Prático 9
  Exercício Prático 9
- Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros :
Branco, Vermelho, Preto, Cinza, Prata e Azul
- Inicie o valor da enumeração com 1
- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro
- Altere o construtor da classe incluindo o campo Cor para criar objetos usando a Cor selecionada
- Defina um menu de opções exibindo o nome da Cor e o seu valor
- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor
- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da
cor a partir do valor da Cor recebida
 
 */
Console.WriteLine("Exercicio Prático 9");

//using ClassesMetodos.ExercicioPratico9;
Carro carro1 = new Carro("Ford", "Ka", 2020, 45000.00m);
Console.WriteLine("Selecione a cor do carro:");
foreach (Cores cor in Enum.GetValues(typeof(Cores)))
{
    Console.WriteLine($"{(int)cor} - {cor}");
}
int corSelecionada;
while (true)
{
    Console.Write("Digite o número correspondente à cor desejada: ");
    if (int.TryParse(Console.ReadLine(), out corSelecionada) && Enum.IsDefined(typeof(Cores), corSelecionada))
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}
carro1.Cor = corSelecionada;
carro1.ExibirInfo(carro1.Cor);  

