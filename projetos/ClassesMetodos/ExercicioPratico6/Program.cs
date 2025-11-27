/* Exercício Prático 6
x- Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para
todos os carros
y- Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
z- Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static.

*/
Console.WriteLine("Exercício Prático 6");

Carro.ObterValorIPVA();
Console.WriteLine($"Valor do IPVA: {Carro.ValorIpva}%");   

public class Carro
{
    public static double ValorIpva;

    public static void ObterValorIPVA()
    {
        ValorIpva = 4;
    }
}
/* Explicação: A palavra-chave static em C# é usada para definir membros que pertencem à classe em si,
e não a instâncias específicas dessa classe. Isso significa que você pode acessar membros estáticos sem criar um objeto da classe. 
No exemplo acima, o campo ValorIpva e o método ObterValorIPVA são estáticos, permitindo que sejam acessados diretamente através da classe Carro, sem a necessidade de instanciar um objeto Carro. Isso é útil para valores ou comportamentos que são compartilhados entre todas as instâncias da classe.


*/
