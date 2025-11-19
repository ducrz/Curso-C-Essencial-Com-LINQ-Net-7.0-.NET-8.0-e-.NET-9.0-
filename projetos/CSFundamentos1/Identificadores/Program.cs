Console.WriteLine("Definindo Identificadores em C#");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//Identificadores inválidos
//int 5idade; //Não pode começar com número

//int $valor; //Não pode começar com caractere especial (exceto _)
//int valor#Total; //Não pode conter caracteres especiais
//string nome completo; //Não pode conter espaços

//Para nome de variáveis : camel case
string descontoTotal;
string desconto_total;

//Constantes: recomendação é usar letras maiúsculas com underline
const double VALOR_PI = 3.14;
string PREFIXO = "12";
string PREFIXO_SP = "11";


Console.ReadLine();


//Para nomes de classes e métodos: pascal case
class ImprimirTexto
{
    public void ImprimeNome() //Método 
    {
        Console.WriteLine("Eduardo");
    }
}
