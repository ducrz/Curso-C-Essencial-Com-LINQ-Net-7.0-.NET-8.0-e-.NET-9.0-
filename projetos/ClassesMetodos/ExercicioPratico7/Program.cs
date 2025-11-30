/*
Exercício Prático 7
w- Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.
w1- Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se
for informado maior que 2022 seja atribuído 2022 ao valor do ano.
w2- Explicar a diferença entre campo e propriedade.

*/
Console.WriteLine("Exercício Prático 7 - Classes e Métodos");

Carro carro1 = new Carro();
carro1.Marca = "Toyota";
carro1.Modelo = "Corolla";
carro1.Ano = 1995; // Deve ser ajustado para 2000
Console.WriteLine($"Carro 1: {carro1.Marca} {carro1.Modelo} {carro1.Ano}");     

Carro carro2 = new Carro();
carro2.Marca = "Honda";
carro2.Modelo = "Civic";
carro2.Ano = 2025; // Deve ser ajustado para 2022
Console.WriteLine($"Carro 2: {carro2.Marca} {carro2.Modelo} {carro2.Ano}"); 

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = value;
            }
        }
    }
}   

/*
Diferença entre campo e propriedade:
- Campo: Um campo é uma variável declarada diretamente dentro de uma classe ou struct. Ele armazena dados
  e pode ser acessado diretamente. Campos geralmente têm visibilidade limitada (público, privado, protegido, etc.) e não possuem
  lógica adicional associada a eles.

- Propriedade: Uma propriedade é um membro de uma classe que fornece um mecanismo flexível para ler, gravar ou calcular o valor
  de um campo privado. Propriedades geralmente encapsulam campos privados e podem incluir lógica adicional nos métodos get e set para controlar como os valores são acessados ou modificados.
  Isso permite validação, transformação de dados e outras operações ao interagir com os dados da classe.
*/