/* Métodos com retorno
Os métodos podem retornar valores para os seus chamadores.


Se o tipo de retorno (o tipo listado antes do nome do método) nṍ for void, o método poderá retornar um
valor usando a instrução return.

Uma instrução return seguida por um valor que corresponda ao tipo de retono, retornará esse valor
ao chamador do método.

public int Somar(int n1, int n2){
    var soma = n1+n2;
    return soma;
}

*/
Console.WriteLine("Métodos com retorno");

Calculadora calc = new Calculadora();

var valor = calc.Somar(10,10);
Console.WriteLine(valor);
Console.WriteLine(calc.Somar);

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
