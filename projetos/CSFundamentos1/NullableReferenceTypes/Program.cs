/* Nullable Reference Types

Null e Nullable

<Nullable>enabled</Nullable>

Null Conditional Operator (?.)

Tipos de valor e tipos de referência
As variáveis de um tipo de valor (tipos numéricos, char, bool, struct), sempre
tem um valor e são armazenadas na memória Stack.
As variáveis de um tipo de referência (object, string, class) contém uma referência
ao local onde o valor pode estar armazenado e são armazenadas
na memória Heap.

Tipos por referência

Um tipo de referência pode não ter nenhuma referência.
Isso é expresso com o valor null (nulo)

Se uma variável de um tipo de referência for igual a null,
ela não tem nenhuma referência a um valor na memória Heap.

Isso também ocorre quando declaramos uma variável de um tipo de referência
sem inicializá-la.

O valor padrão de uma variável de um tipo por referência é null.


*/

Console.WriteLine("Nullable Reference Types em  C#");

string? nome = null; //Não é um erro, é um alerta

Console.WriteLine(nome?.ToUpper());

Console.ReadKey();
