/* Exercício Prático 10
- Explique como poderíamos substituir o método ObterValorIPVA() de forma a inicializar o campo estático
ValorIpva quando uma instância da classe fosse criada.
- Implemente o código que realiza essa substituição
- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para internal ?
- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para private ?


*/
Console.WriteLine("Exercício Prático 10");

public class Veiculo
{
    public static decimal ValorIpva;

    // Construtor da classe
    public Veiculo(decimal valorIpva)
    {
        // Inicializa o campo estático quando uma instância é criada
        ValorIpva = valorIpva;
    }

    // Método para obter o valor do IPVA
    public decimal ObterValorIPVA()
    {
        return ValorIpva;
    }
}

// Exemplo de uso
class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância de Veiculo, o que inicializa o ValorIpva
        Veiculo carro = new Veiculo(1500.00m);  
        Console.WriteLine($"Valor do IPVA: {carro.ObterValorIPVA()}");
    }
}

/* Respostas:
- Para substituir o método ObterValorIPVA() e inicializar o campo estático ValorIpva quando uma instância da classe for criada, podemos utilizar o construtor da classe Veiculo
- Alterar o modificador de acesso do campo estático ValorIpva de public para internal faria com que ele fosse acessível apenas dentro do mesmo assembly, ou seja, outras classes fora do assembly não poderiam acessar esse campo.
- Alterar o modificador de acesso do campo estático ValorIpva de public para private faria com que ele fosse acessível apenas dentro da própria classe Veiculo. Isso impediria qualquer outra classe, mesmo dentro do mesmo assembly, de acessar diretamente o campo ValorIpva.
*/

