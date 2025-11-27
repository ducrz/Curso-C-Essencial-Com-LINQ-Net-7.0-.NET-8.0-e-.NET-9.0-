/* Argumentos nomeados em C#

Diferença entre Argumentos e Parâmetros

Um parâmetro representa um valor que o método espera receber quando for chamado.
A declaração do método define os seus parâmetros.

Um argumento representa o valor que você passa para um parâmetro de método quando você chama o método.

var valor= calc.Somar(10, 10); // 10 e 10 são argumentos

public int Somar(int n1, int n2) // n1 e n2 são parâmetros
{
    return n1 + n2;
}

Argumentos nomeados
Permitem que você especifique um argumento para um parâmetro correspondendo o argumento
com seu nome, em vez de com sua posição na lista de parâmetros.

Liberam você da necessidade de combinar a ordem dos argumentos com a ordem dos parâmetros nas
listas de parâmetros de métodos chamados.

O argumento para cada parâmetro pode ser especificado pelo nome do parâmetro.

*/
Console.WriteLine("Argumentos Nomeados em C#");

/* Passando os argumentos: forma padrão

public void Enviar(string destino, string titulo, string assunto)
{
    Console..WriteLine($"{destino}, {titulo}: {assunto}");
}

email.Enviar("teste@gmail.com", "Olá", "Tudo bem?");

Para chamar o método Enviar passando os argumentos devemos respeitar a ordem dos parâmetros
definidos na lista de parâmetros (padrão).
*/


/* Usando os argumentos nomeados

public void Enviar(string destino, string titulo, string assunto)
{
    Console..WriteLine($"{destino}, {titulo}: {assunto}");
}

email.Enviar(titulo: "Olá", assunto: "Tudo bem?", destino: "teste@gmail.com");

email.Enviar(assunto: "Tudo bem?", destino: "teste@gmail.com", titulo: "Olá");
email.Enviar(titulo: "Olá", destino: "teste@gmail.com", assunto: "Tudo bem?");
*/

Email email = new Email();
email.Enviar("teste@gmail.com", "Olá", "Tudo bem?");

//Argumentos nomeados
email.Enviar(titulo: "Olá", assunto: "Tudo bem?", destino: "teste@gmail.com");

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara{destino}- {titulo} \n Assunto: {assunto}");
    }
}   