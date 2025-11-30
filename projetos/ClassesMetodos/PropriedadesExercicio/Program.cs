/* Propriedades - Exercicio 1

*/
Console.WriteLine("Propriedades - Exercicio 1");

Produto p1 = new Produto();
p1.Nome = "Caderno";    
p1.Preco = 10.00;

p1.EstoqueMinimo = 10;

p1.Exibir();


public class Produto
{
    private string? nome;
    public string? Nome { 
        get{ return nome.ToUpper(); } 
        set { nome = value; }
    }
    private double preco;
    public double Preco { 
        get{ return preco; }
        set
        {
            if (value < 5.00)
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }   
        }
    } 

    private double desconto = 0.05;
    public double Desconto {
        get
        {
            return desconto;
        }
    }

    public double PrecoFinal {
         get { 
            return Preco - (Preco * Desconto); 
            } }
    private int minimo;
    public int EstoqueMinimo { 
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome} \n {Preco.ToString("C")} \n Desconto: {Desconto}% \n Preço Final: {PrecoFinal.ToString("C")} \n Estoque Mínimo: {minimo} ");
    }
}
