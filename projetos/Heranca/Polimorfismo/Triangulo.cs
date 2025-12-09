namespace _Polimorfismo;

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um triangulo..");
        base.Desenhar();
    }
}