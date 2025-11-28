/* Construtor estático

Um construtor estático é usado para inicializar quaisquer membros estáticos ou para
executar uma ação específica que precisa ser executada apenas uma vez.

Ele é chamado automaticamente antes que a primeira instância seja criada ou que qualquer membro
estático seja referenciado.

Membros estáticos são membros que usam o modificador static e que estão associados com a classe e não
com uma instância particular da classe ou seja, para acessar membros estáticos não precisamos criar
uma instância da classe.


Propriedades de um construtor estático:
Não usa modificadores de acesso nem tem parâmetros.
Uma classe ou struct só pode ter um único construtor estático.
Um construtor estático não pode ser chamado diretamente
O usuário não tem controle sobre quando o construtor estático é executado no programa.

Se você não fornecer um construtor estático para inicializar campos estáticos, todos os campos estáticos
serão inicializados com seu valor padrão.

Se um construtor estático gerar uma exceção, o runtime não o invocará uma segunda vez, e o membro estático
permanecerá não inicializado durante o tempo de vida do aplicativo.

Sintaxe
Basta criar um construtor sem parâmetros usando a palavra-chave static.

class MinhaClasse
{
    static MinhaClasse() // Construtor estático
    {
        // Código de inicialização estática
    }
}
*/
Console.WriteLine("Construtor estático");

Pessoa p1 = new Pessoa(25, "João");

Console.WriteLine(p1.Nome+" - "+p1.Idade);
Console.WriteLine("Idade mínima: " + Pessoa.IdadeMinima);

Pessoa p2 = new Pessoa(20, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade mínima: " + Pessoa.IdadeMinima);

Console.ReadKey();