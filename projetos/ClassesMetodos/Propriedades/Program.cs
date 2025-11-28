/* Propriedades

Resolve o problema de expor campos de uma classe de forma controlada, respeita
o encapsulamento, permitindo a validação de dados ao definir ou obter valores.

Uma propriedade é um membro da classe que fornece um mecanismo para ler, gravar ou calcular
o valor de um campo privado.

As propriedades podem ser usadas como se fossem membros de dados públicos, mas possuem métodos especiais
chamados de acessadores (get e set) que controlam o acesso ao valor subjacente.

As propriedades permitem que uma classe exponha uma maneira pública de obter e definir valores,
enquanto oculta o código de implementação ou verificação.

Propriedade: sintaxe

Uma propriedade é uma combinação de um campo privado e de dois acessadores: o get e o set.

public class Pessoa{
    private string nome; // campo privado
    public string Nome{ // propriedade pública
        get { return nome; } // acessador get
        set { nome = value; } // acessador set
    }

}

Definição da propriedade Nome:


*/
Console.WriteLine("Propriedades em C#");
