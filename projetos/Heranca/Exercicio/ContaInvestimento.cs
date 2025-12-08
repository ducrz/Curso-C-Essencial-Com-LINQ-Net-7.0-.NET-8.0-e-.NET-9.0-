namespace Heranca_Exercicio_Resolvido;
public class ContaInvestimento : Conta
{
    public override double Juros { get; set; } = 0.009;
    public double Imposto { get; set; } = 0.001;

    private decimal CalculaImposto(double imposto)
    {
        return Saldo * (decimal)Imposto;
    }

    public override decimal Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo = Saldo - valor - CalculaImposto(Imposto);
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente...");
            return Saldo;
        }
    }
}