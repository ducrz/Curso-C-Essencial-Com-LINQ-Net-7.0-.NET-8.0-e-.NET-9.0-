/* Enum

Enum ou Enumeration é um tipo de dado especial definido pelo usuário

Enum é uma "classe" especial que é definida por um conjunto de constantes nomeadas do tipo numérico.

O uso do tipo enum ajuda a tornar o programa mais fácil de entender e manter.

Sintaxe

Uma enumeração é definida usando a palavra-chave enum, diretamente dentro de um namespace, classe ou struct
e todos os nomes das constantes podem ser declarados e separados por virgula.

*/
Console.WriteLine("Enum");

//Nomenclatura de Enum em PascalCase

/*
enum DiasDaSemana
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}
enum Categorias{
    Moda,
    Automotivo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos
}
enum CodigoErro{
    Nenhum = 0,
    Desconhecido = 1,
    ConexaoFalhou = 100,
    DadosInvalidos = 200
}
*/

/* Enum - Valores
Por padrão, os valores associdados aos membros de um enum são do tipo int;

O primeiro membro de um enum tem o valor 0 e o valor de cada membro seguinte
é incrementado de 1. (quando nenhum valor for atribuído).

Enum é um tipo de valor, sendo alocado na memória stack.

Podemos atribuir valores diferentes aos membros de uma enum.

Uma alteração no valor padrão de um mebro enum atribuirá automaticamente
valores incrementais aos outros membros sequencialmente.

Um enum pode ser acessado usando a sintaxe de ponto: nome_enum.mrmbro.

DiasDaSemana.Domingo tem o valor 0
DiasDaSemana.Segunda tem o valor 1
DiasDaSemana.Terca tem o valor 2
DiasDaSemana.Quarta tem o valor 3
DiasDaSemana.Quinta tem o valor 4

PAra converter o valor do membro do enum para o seu tipo numérico, é preciso realizar uma conversão
forçada ou cast.

int dia = (int)DiasDaSemana.Quarta; // dia recebe 3

O enum pode ser de qualquer tipo de dados numéricos como: byte, sbyte, short, ushort,
int, uint, long ou ulong

PAra definir o tipo basta informar o nome do tipo após o nome do enum.

enum DiasDaSemana : byte
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

byte dia = (byte)DiasDaSemana.Sabado; 
*/

Console.WriteLine(DiasDaSemana.Domingo); 
Console.WriteLine(DiasDaSemana.Terca); 

int dia1 = (int)DiasDaSemana.Domingo; 
int dia1 = (int)DiasDaSemana.Terca; 

Console.WriteLine($"\n{DiasDaSemana.Domingo} = {dia1}");

Console.WriteLine($"\n{DiasDaSemana.Terca} = {dia2}");

enum DiasDaSemana
{
    Domingo,
    Segunda,
    Terca,
    Quarta = 5,
    Quinta,
    Sexta,
    Sabado
}
