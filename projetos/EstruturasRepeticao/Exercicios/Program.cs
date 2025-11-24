
Console.WriteLine("Exercício de Estruturas de Controle e Repetição");

/* 1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
Encontre o maior dentre 3 números:
Primeiro Número : 65465
Segundo Número : 64658
Terceiro Número : 65464
O primeiro número : 65465 é o maior
*/
int numero1, numero2, numero3;
Console.WriteLine("Digite o primeiro número:");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número:");
numero3 = Convert.ToInt32(Console.ReadLine());
if (numero1 >= numero2 && numero1 >= numero3)
{
    Console.WriteLine("O primeiro número : " + numero1 + " é o maior");
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    Console.WriteLine("O segundo número : " + numero2 + " é o maior");
}
else
{
    Console.WriteLine("O terceiro número : " + numero3 + " é o maior");
}

Console.ReadKey();

/* Exercícios
2- Escreva um programa para calcular a raiz da equação quadrática :
- Para calcular as raízes use a fórmula de Báskara : onde
- Considere a, b e c números inteiros (positivos, negativos e o zero)
- Solicite a entrada de a , b e c e informe se existe ou não raiz real
Dica: Utilize os recursos da classe Math e use a instrução if-else-if

Modelo de saídas:
Cálculo da equação do segundo grau (ax^2+bx+c) :
Informe o valor de a : 2
Informe o valor de b : 3
Informe o valor de c : 4
As raízes são imaginárias;
Sem solução para os números reais.
Cálculo da equação do segundo grau (ax^2+bx+c) :
Informe o valor de a : 1
Informe o valor de b : -1
Informe o valor de c : -12
Ambas as raízes são reais e diferentes
Primeira raiz x1= 4
Segunda raiz x2= -3


*/
double a, b, c, delta, x1, x2;
Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c) :");
Console.WriteLine("Informe o valor de a :");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o valor de b :");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o valor de c :");
c = Convert.ToDouble(Console.ReadLine());       
delta = (b * b) - 4 * a * c;
if (delta < 0)
{
    Console.WriteLine("As raízes são imaginárias;");
    Console.WriteLine("Sem solução para os números reais.");
}
else if (delta == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine("Ambas as raízes são reais e iguais");
    Console.WriteLine("Raiz x1= " + x1);
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Ambas as raízes são reais e diferentes");
    Console.WriteLine("Primeira raiz x1= " + x1);
    Console.WriteLine("Segunda raiz x2= " + x2);
}   
Console.ReadKey();

/* 3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
while, do-while e for.
Os 10 primeiros números naturais são :
1 2 3 4 5 6 7 8 9 10
A soma dos números é : 55

*/
int contador = 1;
int soma = 0;
Console.WriteLine("Os 10 primeiros números naturais são :");
while (contador <= 10)
{
    Console.Write(contador + " ");
    soma += contador;
    contador++;
}
Console.WriteLine();
Console.WriteLine("A soma dos números é : " + soma);
Console.ReadKey();  

/* 4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero
recebido via teclado
- Verifique se o número é maior que zero e emita uma mensagem
- Considere a tabela de multiplicação de 1 até 10
- Após exibir a tabela torne a solicitar outro número
- Para sair do loop defina uma condição de saída
Dica: Use os loop while e for e para sair a instrução break

*/
int numero;
while (true)
{
    Console.WriteLine("Digite um número natural maior que zero para ver a tabela de multiplicação (ou digite um número negativo para sair):");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero <= 0)
    {
        Console.WriteLine("Número inválido. Saindo do programa.");
        break;
    }
    Console.WriteLine("Tabela de multiplicação de " + numero + ":");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(numero + " x " + i + " = " + (numero * i));
    }
}
Console.ReadKey();

/* 5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de
resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
Não utilize a instrução break.

Abaixo um modelo de saida esperado :

Qual a instrução para sair de um loop ?
a.quit
b.continue
c.break
d.exit
Qual a opção correta ? (Tecle x para sair)

Dica : Usar loop while e instruções if-elseif

*/
string resposta;
while (true)
{
    Console.WriteLine("Qual a instrução para sair de um loop ?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");
    Console.WriteLine("d. exit");
    Console.WriteLine("Qual a opção correta ? (Tecle x para sair)");
    resposta = Console.ReadLine();
    if (resposta == "c")
    {
        Console.WriteLine("Resposta correta!");
    }
    else if (resposta == "x")
    {
        Console.WriteLine("Saindo do programa.");
        break;
    }
    else
    {
        Console.WriteLine("Resposta incorreta. Tente novamente.");
    }
}
Console.ReadKey();

/* 6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3
maneiras diferentes:
- Incrementando 2 em cada passo
- Incrementando 1 em cada passo
- Com e loop infinito (use "break" e "continue")

*/
Console.WriteLine("Números pares de 10 a 20 (incrementando 2 em cada passo):");
for (int i = 10; i <= 20; i += 2)
{
    if (i == 16)
    {
        continue;
    }
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("Números pares de 10 a 20 (incrementando 1 em cada passo):");
for (int i = 10; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        if (i == 16)
        {
            continue;
        }
        Console.Write(i + " ");
    }
}
Console.WriteLine();
Console.WriteLine("Números pares de 10 a 20 (loop infinito):");
int numeroPar = 10;
while (true)
{
    if (numeroPar > 20)
    {
        break;
    }
    if (numeroPar == 16)
    {           
        numeroPar += 2;
        continue;
    }
    Console.Write(numeroPar + " ");
    numeroPar += 2;
}
Console.WriteLine();
Console.ReadKey();

/* 7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:
*
**
***
**** (dica : loop aninhado)

*/
Console.WriteLine("Triângulo de ângulo reto usando asterisco (*):");
int linhas = 4;
for (int i = 1; i <= linhas; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();

/* 8- Escreva um programa para calcular o fatorial de um número inteiro.
O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1
Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

*/
int n, fatorial = 1;
Console.WriteLine("Digite um número inteiro para calcular o fatorial:");
n = Convert.ToInt32(Console.ReadLine());
for (int i = n; i >= 1; i--)
{
    fatorial *= i;
}
Console.WriteLine("O fatorial de " + n + " é: " + fatorial);
Console.ReadKey();

/* 9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

Modelo de saída:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18
2 x 10 = 20
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
3 x 4 = 12
3 x 5 = 15
3 x 6 = 18
3 x 7 = 21
3 x 8 = 24
3 x 9 = 27
3 x 10 = 30

*/
int multiplicando = 2;
do
{
    int multiplicador = 1;
    do
    {
        Console.WriteLine(multiplicando + " x " + multiplicador + " = " + (multiplicando * multiplicador));
        multiplicador++;
    } while (multiplicador <= 10);
    multiplicando++;
} while (multiplicando <= 6);
Console.ReadKey();

/* 10- Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de
um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a
instrução switch, break e default em um loop infinito e defina uma condição de saida.)
Nota Avaliação
10 A+
9 A
7 e 8 B
6 C
5 E
0 a 4 F

*/
int nota;
while (true)
{
    Console.WriteLine("Digite a nota do aluno (0 a 10) ou um número negativo para sair:");
    nota = Convert.ToInt32(Console.ReadLine());
    if (nota < 0)
    {
        Console.WriteLine("Saindo do programa.");
        break;
    }
    switch (nota)
    {
        case 10:
            Console.WriteLine("Avaliação: A+");
            break;
        case 9:
            Console.WriteLine("Avaliação: A");      
            break;
        case 8:
        case 7:
            Console.WriteLine("Avaliação: B");
            break;
        case 6:
            Console.WriteLine("Avaliação: C");
            break;
        case 5:
            Console.WriteLine("Avaliação: E");
            break;
        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            Console.WriteLine("Avaliação: F");
            break;
        default:
            Console.WriteLine("Nota inválida. Digite um número entre 0 e 10.");
            break;
    }
}
Console.ReadKey();

/* 11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números
inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e
quando isso ocorrer exibir uma mensagem de alerta)

Modelos de saída esperados:
Informe o primeiro número: 78
Informe o operando (+, -, /, *): +
Informe o segundo número: 22
78 + 22 = 100

Informe o primeiro número: 1
Informe o operando (+, -, /, *): /
Informe o segundo número: 0
Não existe divisão por zero !!!
1 / 0 = 8 (<- Símbolo de infinito)

*/
int num1, num2;
char operando;
Console.WriteLine("Informe o primeiro número:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o operando (+, -, /, *):");
operando = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Informe o segundo número:");
num2 = Convert.ToInt32(Console.ReadLine());
switch (operando)
{
    case '+':
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        break;
    case '-':
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        break;
    case '*':
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        break;
    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Não existe divisão por zero !!!");
            Console.WriteLine(num1 + " / " + num2 + " = ∞");
        }
        else
        {
            double resultado = (double)num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
        }
        break;
    default:
        Console.WriteLine("Operando inválido.");
        break;
}
Console.ReadKey();