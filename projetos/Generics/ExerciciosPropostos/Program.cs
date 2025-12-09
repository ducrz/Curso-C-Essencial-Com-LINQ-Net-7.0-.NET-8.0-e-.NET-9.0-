/* Generics e Coleções Genéricas – Exercícios
*/

/*
1- Quais das seguintes classes estão presentes no nameaspace System.Collections.Generic :
Stack<T> 2-Tree<T> 3-SortedDictionary<T> 4-SortedArray<T>
a-) 1 e 2 somente
b-) 2 e 4 somente
c-) 1 e 3 somente
d-) Todas as opções
e-) Nenhuma das opções
Resposta: c-) 1 e 3 somente

*/

/* 2- Dado o trecho de código abaixo :
public class Generic<T>
{
public T Campo;
public void TesteSub()
{
T i = Campo + 1;
}
}
class MeuPrograma
{
static void Main(string[] args)
{
Generic<int> gen = new Generic<int>();
gen.TesteSub();
}
}
Qual das seguintes declarações são verdadeiras ?

a-) A adição produzirá o resultado 1.
b-) O resultado da adição depende do sistema.
c-) O programa gerará uma exceção em tempo de execução.
d-) O compilador vai relatar o erro: O operador '+' não está definido para os tipos T e int.
e-) Nenhuma das acima.

Resposta: d-) O compilador vai relatar o erro: O operador '+' não está definido para os tipos T e int.


*/

/* 3- Quais das declarações a seguir são verdadeiras para o recurso Generics da plataforma .NET ?
1- Generics é um recurso de linguagem.
2- Podemos criar uma classe genérica, porém não podemos criar uma interface genérica em C#
3- Delegates genéricos não são permitidos em C#.
4- O recurso Generics são úteis em classes de coleção na plataforma .NET
a- 1 e 2 somente
b- 1, 2 e 3 somente
c- 1 e 4 somente
d- Todas as opções
e- Nenhuma das opções

Resposta: c- 1 e 4 somente


*/

/* 4- Qual o resultado da execução do código abaixo:
Teste teste = new Teste();
teste.MetodoTeste<string>("Usando Generics -> ");
teste.MetodoTeste<float>(4.2f);
Console.ReadKey();
public class Teste
{
public void MetodoTeste<T>(T arg)
{
Console.Write(arg);
}
}
a-) O programa vai compilar e na execução imprimirá: Generics -> 4.2
b-) Uma classe não genérica Teste não pode ter um método genérico MetodoTeste<T>
c-) O compilador vai gerar um erro.
d-) O programa irá gerar uma exceção em tempo de execução
e-) Nenhuma das opções acima.


Resposta: a-) O programa vai compilar e na execução imprimirá: Generics -> 4.2

*/

/* 5- Qual o resultado da execução do código abaixo:
Generic<String> g = new Generic<String>();
g.Campo = "Exercício Generics";
Console.WriteLine(g.Campo);
Console.ReadKey();
public class Generic<T>
{
public T? Campo;
}

a-) O nome Generic não pode ser usado como um nome de classe porque é uma palavra-chave.
b-) Não podemos criar uma classe genérica e definir um campo genérico
c-) Vai imprimir a string "Exercício Generics" no console.
d-) O campo de membro da classe Generic não é acessível diretamente.
e-) Nenhuma das acima.

Resposta: c-) Vai imprimir a string "Exercício Generics" no console.


*/

/* 6- Para o trecho de código fornecido abaixo, quais das seguintes declarações é válida ?
public class MeuContainer<T> where T: class, IComparable
{
// Insira o código aqui
}

a-) A classe MeuContainer requer que seu tipo de argumento implemente a interface IComparable.
b-) O argumento do tipo da classe MeuContainer deve ser IComparable.
c-) O compilador reportará um erro para este bloco de código.
d-) A classe MeuContainer requer que seu argumento de tipo seja um tipo de referência e implemente
a interface IComparable.

Resposta: d-) A classe MeuContainer requer que seu argumento de tipo seja um tipo de referência e implemente
a interface IComparable.


*/

/* 7- Qual das seguintes afirmações é válida sobre as vantagens dos genéricos?
a-) Generics transferem o ônus da segurança de tipo para o programador em vez do compilador.
b-) Generics requerem o uso de conversão de tipo explícito.
c-) Generics fornecem segurança de tipo sem a sobrecarga de várias implementações.
d-) Generics eliminam a possibilidade de erros de execução.
e-) Nenhuma das acima

Resposta: c-) Generics fornecem segurança de tipo sem a sobrecarga de várias implementações.

*/

/* 8- Escreva um programa para adicionar dois números inteiros usando o conceito de Generics

*/

using System;
namespace ExerciciosPropostos
{
    public class Generic<T>
    {
        public T Adicionar(T a, T b)
        {
            dynamic x = a;  
            dynamic y = b;
            return x + y;
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> gen = new Generic<int>();
            int resultado = gen.Adicionar(5, 10);
            Console.WriteLine("Resultado da adição: " + resultado);
            Console.ReadKey();
        }
    }
}       

/* 9- Escreva um programa que crie uma lista de objetos Aluno que contém as propriedades : Nome,
Idade e Sexo. A seguir defina 5 objetos do tipo Aluno e exiba uma lista de objetos alunos no console.

*/
//using System.Collections.Generic;   
namespace ExerciciosPropostos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno { Nome = "Ana", Idade = 20, Sexo = "Feminino" },
                new Aluno { Nome = "Bruno", Idade = 22, Sexo = "Masculino" },
                new Aluno { Nome = "Carla", Idade = 19, Sexo = "Feminino" },
                new Aluno { Nome = "Daniel", Idade = 21, Sexo = "Masculino" },
                new Aluno { Nome = "Eva", Idade = 23, Sexo = "Feminino" }
            };

            Console.WriteLine("Lista de Alunos:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Sexo: {aluno.Sexo}");
            }

            Console.ReadKey();
        }
    }
}       

/* 10 - implemente um programa que verifica se uma expressão matemática contém parênteses
balanceados seguindo os seguintes passos:
1. Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos.
2. Percorra cada caractere da expressão matemática.
3. Se o caractere for um parêntese aberto ( '(', '{', '['), adicione-o à pilha.
4. Se o caractere for um parêntese fechado ( ')', '}', ']' ), verifique se a pilha não está vazia e se o último
parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o
último parêntese aberto da pilha. Caso contrário, a expressão matemática não contém parênteses
balanceados.
5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver
vazia, a expressão matemática contém parênteses balanceados. Caso contrário, a expressão não é
balanceada

*/
using System.Collections.Generic;
namespace ExerciciosPropostos
{
    class Program
    {
        static bool VerificarParentesesBalanceados(string expressao)
        {
            Stack<char> pilha = new Stack<char>();
            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == '{' || caractere == '[')
                {
                    pilha.Push(caractere);
                }
                else if (caractere == ')' || caractere == '}' || caractere == ']')
                {
                    if (pilha.Count == 0)
                    {
                        return false;
                    }

                    char ultimoAberto = pilha.Pop();
                    if (!Corresponde(ultimoAberto, caractere))
                    {
                        return false;
                    }
                }
            }
            return pilha.Count == 0;
        }       
        static bool Corresponde(char aberto, char fechado)
        {
            return (aberto == '(' && fechado == ')') ||
                   (aberto == '{' && fechado == '}') ||
                   (aberto == '[' && fechado == ']');
        }       
        static void Main(string[] args)
        {
            string expressao = "{[()]}";
            bool balanceado = VerificarParentesesBalanceados(expressao);    
            if (balanceado)
            {
                Console.WriteLine("A expressão matemática contém parênteses balanceados.");
            }
            else
            {
                Console.WriteLine("A expressão matemática não contém parênteses balanceados.");
            }
            Console.ReadKey();
        }
    }
}   

/* 11. Implementar um programa que simula uma fila de impressão seguindo o seguinte roteiro:
• Crie uma variável do tipo Queue<string> para representar a fila de impressão.
• Crie um loop que irá executar até que a fila de impressão esteja vazia.
• Dentro do loop, verifique se a fila de impressão não está vazia. Se não estiver vazia, remova o primeiro
elemento da fila usando o método Dequeue() e imprima na tela que o arquivo "X" está sendo impresso.
• Simule o tempo de impressão com um Thread.Sleep() por um período aleatório de tempo entre 1 e 5
segundos.
• Após simular a impressão do arquivo, imprima na tela que o arquivo "X" foi impresso com sucesso.
• Repita os passos 3 a 5 até que a fila de impressão esteja vazia.

*/
using System.Collections.Generic;
using System.Threading;
namespace ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaImpressao = new Queue<string>();
            filaImpressao.Enqueue("Documento1.pdf");
            filaImpressao.Enqueue("Relatorio2.docx");
            filaImpressao.Enqueue("Imagem3.png");   
            Random random = new Random();
            while (filaImpressao.Count > 0)
            {
                string arquivoAtual = filaImpressao.Dequeue();
                Console.WriteLine($"Imprimindo o arquivo: {arquivoAtual}");
                int tempoImpressao = random.Next(1000, 5001);
                Thread.Sleep(tempoImpressao);
                Console.WriteLine($"Arquivo {arquivoAtual} impresso com sucesso.");     
            }
            Console.ReadKey();
        }
    }
}


/* 12- Escreva um programa seguindo as seguintes orientações:
Declare um método genérico chamado ReverterEImprimir em uma classe não genérica chamada
Exemplo.
O método recebe como parâmetro um array de qualquer tipo.

A seguir declare três tipos diferentes de array : um array de int , um array de strings e um array de
double
Invoque o método duas vezes com cada array.
Na primeira vez invoque o método com um determinado array, onde ele usa explicitamente o
parâmetro de tipo.
Na segunda vez, invoque o método onde o tipo é inferido.

*/

namespace ExerciciosPropostos
{
    public class Exemplo
    {
        public void ReverterEImprimir<T>(T[] array)
        {
            Array.Reverse(array);
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo exemplo = new Exemplo();       
            int[] arrayInt = { 1, 2, 3, 4, 5 };
            string[] arrayString = { "um", "dois", "três", "quatro", "cinco" };
            double[] arrayDouble = { 1.1, 2.2, 3.3, 4.4, 5.5 };       
            Console.WriteLine("Revertendo e imprimindo array de int (tipo explícito):");
            exemplo.ReverterEImprimir<int>(arrayInt);       
            Console.WriteLine("Revertendo e imprimindo array de int (tipo inferido):");
            exemplo.ReverterEImprimir(arrayInt);       
            Console.WriteLine("Revertendo e imprimindo array de string (tipo explícito):");
            exemplo.ReverterEImprimir<string>(arrayString);       
            Console.WriteLine("Revertendo e imprimindo array de string (tipo inferido):");
            exemplo.ReverterEImprimir(arrayString);       
            Console.WriteLine("Revertendo e imprimindo array de double (tipo explícito):");
            exemplo.ReverterEImprimir<double>(arrayDouble);       
            Console.WriteLine("Revertendo e imprimindo array de double (tipo inferido):");
            exemplo.ReverterEImprimir(arrayDouble);       
            Console.ReadKey();
        }
    }
}   

