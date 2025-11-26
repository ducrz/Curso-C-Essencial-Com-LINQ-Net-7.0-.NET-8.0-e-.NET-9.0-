/* Passagem de argumentos por referência (out)
A palavra-chave out faz com que os argumentos sejam passados por referência.

Devemos usar a palavra-chave out na declaração do método e na invocação do método.

A principal diferença é que o out transfere dados para fora do método e não para dentro dele.

Variáveis passadas como argumentos out não precisam ser inicializadas antes de serem
passadas em uma chamada de método.

No entanto, o método chamado deve atribuir um valor ao parâmetro definido com a palavra-chave out
antes que o método seja retornado.


*/
Console.WriteLine("Passagem de argumentos por referência (out)");

//Calcular a área do perímetro da circunferência usando o raio - sem out

Circulo circulo = new Circulo();

double perimetro = circulo.CalculaPerimetro(raio);
double area = circulo.CalculaArea(raio);
public class Circulo
{
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }
    public double CalculaPerimetro  (double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}


//Calcular a área do perímetro da circunferência usando o raio - Usando out

Circulo circulo = new Circulo();

Console.WriteLine("Informe o raio do círculo:");
double raio = Convert.ToDouble(Console.ReadLine());



double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine("Perímetro da Circunferência: " + circunferencia);
Console.WriteLine("Área da Circunferência: " + area);

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;       
    }
   
}
