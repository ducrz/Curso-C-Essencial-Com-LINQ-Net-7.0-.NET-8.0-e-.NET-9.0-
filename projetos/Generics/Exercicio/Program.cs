/* 
Generics - Exercício

Criar uma classe Genérica que deverá ser implementada de acordo com os seguintes requisitos:

1- Ser uma array genérico de uma dimensão de tamanho igual a 5;
2- Possuir um método Adicionar() responsável por adicionar qualquer tipo de objeto no array;
3- Possuir uma propriedade indexer como uma implementação para um laço for(usar o conceito de indexador); 

A seguir analisar a implementação feita levando em conta os 3 benefícios principais do Generics:

1- Segurança de tipagem
2- Desempenho
3- Reutilização de código.

Dica: Utilize a classe ArrayList não genérica para realizar a análise dos 3 tópicos acima.
*/
using System;
using System.Collections;   

namespace ExercicioGenerics
{
    // Classe Genérica
    public class ArrayGenerico<T>
    {
        private T[] array;
        private int count;

        public ArrayGenerico()
        {
            array = new T[5];
            count = 0;
        }

        // Método Adicionar
        public void Adicionar(T item)
        {
            if (count < array.Length)
            {
                array[count] = item;
                count++;
            }
            else
            {
                throw new InvalidOperationException("Array cheio");
            }
        }

        // Propriedade indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Índice fora do alcance");
                }
                return array[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe genérica com diferentes tipos de dados
            ArrayGenerico<int> intArray = new ArrayGenerico<int>();
            intArray.Adicionar(1);
            intArray.Adicionar(2);
            intArray.Adicionar(3);

            Console.WriteLine("Array de Inteiros:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            ArrayGenerico<string> stringArray = new ArrayGenerico<string>();
            stringArray.Adicionar("Olá");
            stringArray.Adicionar("Mundo");

            Console.WriteLine("\nArray de Strings:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}       