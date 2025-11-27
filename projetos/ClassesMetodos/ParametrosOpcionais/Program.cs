/* Parametros Opcionais em C#

Permitem definir parâmetros em uma assinatura de método que o chamador do método pode omitir.

Cada parâmetro opcional deve ter um valor padrão como parte de sua definição.
Se nenhum argumento for enviado para esse parâmetro, o valor padrão será usado.

Os parâmetros opcionais são definidos no final da lista de parâmetros, depois de todos os 
parâmetros obrigatórios (quando existirem).


Parâmetros não opcionais
public void Enviar(string destino, string titulo, string assunto){
    Console.WriteLine($"{destino}, {titulo}, {assunto}");
    }


Parâmetros opcionais
public void Enviar(string destino, string titulo = "Reunião", string assunto = "Avaliação"){
    Console.WriteLine($"{destino}, {titulo}, {assunto}");
    }

Os parâmetros titulo e assunto são opcionais e usam valores padrões definidos.

email.Enviar("teste@email.com"); // Usa os valores padrão para titulo e assunto
*/
Console.WriteLine("Parametros Opcionais em C#");

Console.WriteLine("Informe o destino do email: ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo do email: ");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto do email: ");
var assunto = Console.ReadLine();

Email email = new Email();

email.Enviar(destino); // Usa os valores padrão para titulo e assunto
email.Enviar(destino, titulo); // Usa o valor padrão para assunto
email.Enviar(destino, titulo, assunto); // Usa todos os valores fornecidos
public class Email
{
    public void Enviar(string destino, string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara: {destino} -Titulo: {titulo}\nAssunto: {assunto}\n");
    }
}

