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

public class Pessoa{
    public string Nome{get; set;} // propriedade automática
}


public class Cliente{
    public string? Nome {get; set;} // propriedade automática
    public int Idade {get; set;} // propriedade automática

    public Cliente(string? nome, int idade){
        Nome = nome;
        Idade = idade;
    }
}

Usa um campo de apoio privado para definir e recuperar o valor da propriedade.

O acessador get retorna o valor do campo privado.
O acessador set pode realizar alguma validação  de dados antes de atribuir o valor ao campo privado.

O uso de propriedades permite encapsular a lógica de acesso aos dados da classe, promovendo
boas práticas de programação orientada a objetos.

As propriedades leitura e gravação têm um acessador get e um set (padrão).
As propriedades somente leitura têm um acessador get, mas nenhum acessador set.
As propriedades somente gravação têm um acessador set, mas não tem um acessador get.


Vantagens

Permitem um melhor controle dos membros da classe (reduz a possibilidade de você
ou outros bagunçarem o código).

Os campos privados podem ser somente leitura, se você usar apenas o método get, ou somente gravação, se você 
usar apenas o método set.

São mais flexíveis, pois o propgramador pode alterar uma parte
do código sem afetar outras partes.

Garantem uma maior segurança dos dados, permitindo controlar o acesso.


*/

Console.WriteLine("Propriedades em C#");
