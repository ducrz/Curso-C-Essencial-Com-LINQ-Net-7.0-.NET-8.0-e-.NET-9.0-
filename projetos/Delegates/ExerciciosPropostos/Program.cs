/* Delegates , Lambda, LINQ

*/

/* 1- Considere as seguintes assertivas sobre delegates na linguagem C#. Indique se cada uma é verdadeira
ou falsa:
a-) Um delegate é um tipo de dado que pode ser usado para encapsular um método e chamá-lo
posteriormente.
Resposta: Verdadeiro

b-) Para declarar um delegate em C#, é necessário especificar o tipo de retorno do método que ele
encapsula, bem como os tipos de parâmetros.
Resposta: Verdadeiro

c-) É possível usar o operador += para adicionar vários métodos a um delegate, que serão chamados em
sequência quando o delegate for invocado.
Resposta: Verdadeiro

d-) O delegate pode ser passado como parâmetro para outro método, permitindo que o método receptor
invoque o método encapsulado no delegate.
Resposta: Verdadeiro

e-) O uso de delegates pode melhorar a modularidade e a flexibilidade do código, permitindo que um
método seja substituído por outro sem que isso afete o restante do código.
Resposta: Verdadeiro

f-) Delegates só podem ser usados para encapsular métodos estáticos, não métodos de instância.
Resposta: Falso

g-) O delegate é um recurso exclusivo da linguagem C#, e não pode ser encontrado em outras linguagens de
programação.
Resposta: Falso

h-) Delegates são frequentemente usados em eventos, para permitir que um objeto notifique outros
objetos quando ocorre alguma ação.
Resposta: Verdadeiro

*/

/*
2- Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir
as seguintes especificações:
a-Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna
um inteiro.
b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros
c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.
d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela.
Dica: Utilize o método Invoke do delegate para invocar a operação matemática

*/
using System;
namespace ExerciciosPropostos
{
    // Definição do delegate
    public delegate int OperacaoMatematica(int a, int b);

    class Program
    {
        // Método que implementa a operação de soma
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Criação do objeto delegate e atribuição do método Somar
            OperacaoMatematica operacao = new OperacaoMatematica(Somar);

            // Chamada do delegate e exibição do resultado
            int resultado = operacao.Invoke(5, 10);
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
    }
}

/* 3- Implemente um programa em C# que use multicast delegates para exibir uma mensagem de boas-vindas
ao usuário. O programa deve seguir as seguintes especificações:
a-) Defina um multicast delegate chamado MensagemBoasVindas que não recebe parâmetros e não retorna
nenhum valor.
b-) Defina duas funções que exibem uma mensagem de boas-vindas: uma em português e outra em inglês.
c-) Crie um objeto delegate do tipo MensagemBoasVindas e adicione as duas funções criadas a ele usando o
operador +=.
d-) Chame o delegate para executar as duas funções e exibir as mensagens de boas-vindas.

*/
namespace ExerciciosPropostos   
{
    // Definição do multicast delegate
    public delegate void MensagemBoasVindas();

    class ProgramMulticast
    {
        // Função que exibe a mensagem de boas-vindas em português
        public static void BoasVindasPortugues()
        {
            Console.WriteLine("Bem-vindo ao programa!");
        }

        // Função que exibe a mensagem de boas-vindas em inglês
        public static void BoasVindasIngles()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static void Main(string[] args)
        {
            // Criação do objeto delegate e adição das funções
            MensagemBoasVindas mensagem = null;
            mensagem += BoasVindasPortugues;
            mensagem += BoasVindasIngles;

            // Chamada do delegate para executar as funções
            mensagem.Invoke();
        }
    }
}   


/* 4- Dado o código abaixo, assinale com verdadeiro ou falso cada afirmação sobre os delegates Action,
Predicate e Func da linguagem C#:
int[] numeros = { 1, 2, 3, 4, 5 };
// Delegate Action
Action<int> exibirNumero = num => Console.WriteLine(num);
Array.ForEach(numeros, exibirNumero);
// Delegate Predicate
Predicate<int> ehPar = num => num % 2 == 0;
bool todosPares = Array.TrueForAll(numeros, ehPar);
// Delegate Func
Func<int, int, int> somar = (a, b) => a + b;
int resultado = somar(10, 20);
Console.WriteLine(todosPares);
Console.WriteLine(resultado);
Console.ReadKey();
]
Delegates , Lambda, LINQ
Func<int, int, int> somar = (a, b) => a + b;
int resultado = somar(10, 20);
Console.WriteLine(todosPares);
Console.WriteLine(resultado);
Console.ReadKey();

a- O delegate Action é usado para encapsular um método que recebe um parâmetro e não retorna nenhum
valor. (Verdadeiro ou Falso)
Resposta: Verdadeiro

b- O método Array.ForEach é usado para percorrer todos os elementos de um array e executar um delegate
para cada um deles. (Verdadeiro ou Falso)
Resposta: Verdadeiro

c- O delegate Predicate é usado para encapsular um método que recebe um parâmetro e retorna um valor
booleano. (Verdadeiro ou Falso)
Resposta: Verdadeiro

d- O método Array.TrueForAll retorna true se todos os elementos de um array satisfazem uma condição
especificada por um delegate. (Verdadeiro ou Falso)
Resposta: Verdadeiro

e- O delegate Func é usado para encapsular um método que recebe um ou mais parâmetros e retorna um
valor. (Verdadeiro ou Falso)
Resposta: Verdadeiro

f- O delegate Func pode ter até 16 parâmetros de entrada e um tipo de retorno genérico. (Verdadeiro ou
Falso)
Resposta: Verdadeiro

g- No exemplo acima, o delegate Func é usado para definir um método que soma dois números inteiros.
(Verdadeiro ou Falso)
Resposta: Verdadeiro

h- No exemplo acima, o método somar recebe dois parâmetros e retorna um valor. (Verdadeiro ou Falso
Resposta: Verdadeiro

*/

/* 5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros
de 1 a 20.
Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e
imprima na tela apenas os números pares.

*/
using System;
using System.Collections.Generic;
namespace ExerciciosPropostos
{
    class ProgramAction
    {
        static void Main(string[] args)
        {
            // Criação da lista de inteiros de 1 a 20
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                numeros.Add(i);
            }

            // Definição do delegate Action<int>
            Action<int> imprimirPar = num =>
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            };

            // Percorrendo a lista e chamando o delegate para cada número
            foreach (int numero in numeros)
            {
                imprimirPar(numero);
            }
        }
    }
}   

/* 7- Suponha que você possui uma lista de planetas com informações sobre o nome, diâmetro e massa de cada
planeta.
Crie um programa e implemente um método que recebe essa lista e um delegate Predicate<Planeta> para
filtrar os planetas de acordo com um critério específico


*/
using System;
using System.Collections.Generic;
namespace ExerciciosPropostos
{
    // Definição da classe Planeta
    public class Planeta
    {
        public string Nome { get; set; }
        public double Diametro { get; set; } // em km
        public double Massa { get; set; } // em kg

        public Planeta(string nome, double diametro, double massa)
        {
            Nome = nome;
            Diametro = diametro;
            Massa = massa;
        }
    }

    class ProgramPredicate
    {
        // Método que filtra planetas usando um Predicate<Planeta>
        public static List<Planeta> FiltrarPlanetas(List<Planeta> planetas, Predicate<Planeta> criterio)
        {
            return planetas.FindAll(criterio);
        }

        static void Main(string[] args)
        {
            // Criação da lista de planetas
            List<Planeta> planetas = new List<Planeta>
            {
                new Planeta("Mercúrio", 4879, 3.30e23),
                new Planeta("Vênus", 12104, 4.87e24),
                new Planeta("Terra", 12742, 5.97e24),
                new Planeta("Marte", 6779, 6.42e23),
                new Planeta("Júpiter", 139820, 1.90e27),
                new Planeta("Saturno", 116460, 5.68e26),
                new Planeta("Urano", 50724, 8.68e25),
                new Planeta("Netuno", 49244, 1.02e26)
            };

            // Definição do critério de filtragem: planetas com diâmetro maior que 10000 km
            Predicate<Planeta> criterio = planeta => planeta.Diametro > 10000;

            // Filtragem dos planetas usando o método FiltrarPlanetas
            List<Planeta> planetasFiltrados = FiltrarPlanetas(planetas, criterio);

            // Exibição dos planetas filtrados
            Console.WriteLine("Planetas com diâmetro maior que 10.000 km:");
            foreach (var planeta in planetasFiltrados)
            {
                Console.WriteLine(planeta.Nome);
            }
        }
    }
}   

/* 8 - Qual é a definição correta de expressão lambda em C#?
a) Uma função anônima que pode ser passada como argumento para outros métodos e que pode ser
definida em apenas uma linha de código.
b) Uma função que sempre retorna um valor booleano.
c) Uma função que sempre tem um único parâmetro de entrada.
d) Uma função que sempre retorna um valor inteiro.

Resposta: a) Uma função anônima que pode ser passada como argumento para outros métodos e que pode ser
definida em apenas uma linha de código.

*/

/* 9- Crie um método de extensão para a classe List<int> na linguagem C# que, dado uma lista de inteiros,
retorne a soma de todos os elementos da lista que são ímpares.
Em seguida, crie um programa que instancie uma lista de inteiros com alguns números ímpares e alguns
números pares e use o método de extensão criado para obter a soma dos números ímpares da lista

*/

using System;
using System.Collections.Generic;
namespace ExerciciosPropostos
{
    // Definição da classe de extensão
    public static class ListExtensions
    {
        // Método de extensão para somar números ímpares
        public static int SomarImpares(this List<int> lista)
        {
            int soma = 0;
            foreach (int numero in lista)
            {
                if (numero % 2 != 0)
                {
                    soma += numero;
                }
            }
            return soma;
        }
    }

    class ProgramExtensao
    {
        static void Main(string[] args)
        {
            // Instanciação da lista de inteiros
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Uso do método de extensão para obter a soma dos números ímpares
            int somaImpares = numeros.SomarImpares();

            // Exibição do resultado
            Console.WriteLine("A soma dos números ímpares é: " + somaImpares);
        }
    }
}   

/* 10 - Exercicios sobre LINQ
Exercício 1: Utilizando o método Where
Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter somente as
strings que contenham a letra 'a'.


*/
using System;
using System.Linq;
namespace ExerciciosPropostos
{
    class ProgramLINQ
    {
        static void Main(string[] args)
        {
            // Definição do array de strings    
            string[] palavras = { "casa", "carro", "bicicleta", "avião", "barco", "trem" };
            // Uso do método Where para filtrar as strings que contêm a letra 'a'
            var palavrasComA = palavras.Where(palavra => palavra.Contains('a'));
            // Exibição das palavras filtradas
            Console.WriteLine("Palavras que contêm a letra 'a':");
            foreach (var palavra in palavrasComA)
            {
                Console.WriteLine(palavra);
            }
        }
    }
}
/* Exercício 2: Utilizando o método OrderBy
Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para ordenar os valores
em ordem crescente

*/

using System;
using System.Linq;
namespace ExerciciosPropostos
{
    class ProgramLINQOrderBy
    {
        static void Main(string[] args)
        {
            // Definição do array de inteiros
            int[] numeros = { 5, 2, 8, 1, 4, 7, 6, 3 };
            // Uso do método OrderBy para ordenar os números em ordem crescente
            var numerosOrdenados = numeros.OrderBy(num => num);
            // Exibição dos números ordenados
            Console.WriteLine("Números em ordem crescente:");
            foreach (var numero in numerosOrdenados)
            {                       
                Console.WriteLine(numero);
            }
        }
    }
}

/* Exercício 3: Utilizando o método GroupBy
Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para agrupar as strings por
tamanho

*/
using System;
using System.Linq;
namespace ExerciciosPropostos
{
    class ProgramLINQGroupBy
    {
        static void Main(string[] args)
        {
            // Definição do array de strings
            string[] palavras = { "casa", "carro", "bicicleta", "avião", "barco", "trem" };
            // Uso do método GroupBy
            var gruposPorTamanho = palavras.GroupBy(palavra => palavra.Length);
            // Exibição dos grupos
            Console.WriteLine("Palavras agrupadas por tamanho:");
            foreach (var grupo in gruposPorTamanho)
            {
                Console.WriteLine($"Tamanho {grupo.Key}:");
                foreach (var palavra in grupo)
                {
                    Console.WriteLine($" - {palavra}");
                }       
            }
        }
    }
}

/* Exercício 4: Utilizando o método FirstOrDefault
Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para obter o primeiro
número par do array

*/
using System;
using System.Linq;
namespace ExerciciosPropostos
{
    class ProgramLINQFirstOrDefault
    {           
        static void Main(string[] args)
        {
            // Definição do array de inteiros
            int[] numeros = { 5, 3, 7, 1, 4, 9, 6 };
            // Uso do método FirstOrDefault para obter o primeiro número par
            int primeiroPar = numeros.FirstOrDefault(num => num % 2 == 0);
            // Exibição do resultado
            if (primeiroPar != 0)
            {
                Console.WriteLine("O primeiro número par é: " + primeiroPar);
            }
            else
            {
                Console.WriteLine("Não há números pares no array.");
            }
        }
    }
}   
