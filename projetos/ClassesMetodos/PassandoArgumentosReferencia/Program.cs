/* Passagem de argumentos por referência (ref)

*/
Console.WriteLine("Passagem de argumentos por Referência");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor :" +x);

Calculo calc = new Calculo();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por valor :" +x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar (ref int y)
    {
        y = y * 2;
        Console.WriteLine("\nValor do parâmetro y dentro do método Dobrar :" +y);
    }
}