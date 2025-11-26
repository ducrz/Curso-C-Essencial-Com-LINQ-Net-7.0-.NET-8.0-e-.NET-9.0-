/* Passando Argumentos por valor e por referência 

No C# existem duas maneiras de passar argumentos para métodos: por valor e por referência.

1- Passagem de argumentos por valor (padrão):
Uma cópia do valor do argumento é feita e passada para o parâmetro do método chamado.
As alterações na cópia não afetam o valor davariável original no chamador.

2 - Passagem de argumento por referência (ref e out):
Passa a referência ao mesmo local de memória dos argumentos para os parâmetros;
nenhuma cópia é passada.

O chamador dá ao método a capacidade de acessar e modificar a variável original do chamador
(passa o acesso à variável para o método).

Para fazer isso podemos usar as palavras chave ref e out.

Passagem de argumentos por valor:




*/
Console.WriteLine("Passando Argumentos por Valor e por Referência");

int x = 20;
Console.WriteLine("Valor do argumento x antes de passar por valor " + x);

Calculo calc = new Calculo();   
calc.Dobrar(x);
Console.WriteLine("Valor do argumento x após passar por valor " + x);

public class Calculo
{
    public void Dobrar(int y)
    {
        y = y * 2;
        Console.WriteLine("Valor do parâmetro y no método Dobrar: " + y);
    }
}
