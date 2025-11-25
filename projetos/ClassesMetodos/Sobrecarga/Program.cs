/* Sobrecarga de Métodos

Assinatura de um Método

A assinatura de um método é uma identificação exclusiva de um método para o compilador C#.

A assinatura de um método é formada assim:

- Nome do método
- O número de parâmetros
- O tipo de parâmetros
- A ordem dos parâmetros

O tipo de retorno de um método não faz parte da assinatura do método.

Não é possível ter dois métodos com a mesma assinatura, mesmo que tenham tipos de retorno diferentes.

Exemplo:

public class Calculadora{
    public int Somar(int n1, int n2){
        return n1 + n2;
    }
    public int Somar(int n1, int n2, int n3){
        return n1 + n2 + n3;
    }
    public double Somar(double d1, double d2){
        return d1 + d2;
    }
    public double Somar(int n1, double d2){
        return n1 + d2;
    }
}

Temos quatro métodos com o mesmo nome, mas com assinaturas diferentes(número
ou tipo de parâmetros diferentes).

Exemplo de método que tem sobrecarga:
WriteLine(); da classe Console.

Tipos de dados dos parâmetros diferentes

public void Exibir(string a, int b){
    Console.WriteLine(a);
    Console.WriteLine(b);
}
public void Exibir(int a, string b){
    Console.WriteLine(a);
    Console.WriteLine(b);
}

*/
Console.WriteLine("Sobrecarga de Métodos");

Email email = new Email();
email.Enviar("teste@teste.com");
email.Enviar("teste@teste.com", "Proposta Comercial");
email.Enviar("teste@teste.com", 1500.00m);
email.Enviar(1500.00m, "teste@teste.com");

public class Email
{
    public void Enviar(string endereco){
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto Padrão ");

    }
    public void Enviar(string endereco, string assunto){
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
        
    }
    public void Enviar(string endereco, decimal valor){
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Proposta Comercial");
        Console.WriteLine($"{valor}");
        
    }
    public void Enviar(decimal valor, string endereco){
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Pagamento Fornecedores");
        Console.WriteLine($"{valor}");
        
    }
}
