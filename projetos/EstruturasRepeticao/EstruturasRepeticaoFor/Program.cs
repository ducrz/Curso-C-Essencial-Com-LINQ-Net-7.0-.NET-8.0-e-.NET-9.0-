/* Estrutura de repetição For
Executa um bloco de instruções repetidamente até que a condição
especificada retorne false.

for(inicialização; condição; iteração){
    //bloco de instruções
}

Inicialização: É usado para declarar e inicializar uma variável de controle
que será local e não pode ser acessada fora do loop. É executada primeiro
e apenas uma vez.

Condição: É uma expressão booleana que retorna true ou false. Se a expressão
for avaliada como true, ela executará o loop novamente, caso contrário,
o loop será encerrado.

Quando o número de repetições for conhecido, o for é a melhor escolha.

*/
Console.WriteLine("Estrutura de repetição For");

for(int i = 0; i < 10; i++){
    Console.WriteLine($"Valor de i: {i}");
}

/*
Criar um laço para exibir a tabuada de multiplicação de números inteiros.
*/

int resultado, numero;
Consol.WriteLine("Informe o número inteiro: \t");
numero = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++){
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

/* Instrução For- Múltiplas Expressões

Podemos usar vários expressões dentro de um loop FOR.
Isso significa que podemos ter mais de uma instrução de inicizaliação
e/ou iterador dentro do loop FOR.

*/

for(int i = 0, j = 10; i+j <= 10; i++, j++){
    Console.WriteLine($"i= {i} e j= {j}");
}

/*A inicialização, a condição e a instrução do iterador são opcionais em
um loop FOR e assim podem executar um loop sem essas instruções.

*/

//Exemplo 1: Loop FOR sem definir a inicialização e a instrução de iteração.
int i=1;
for(; i <= 5; ){
    Console.WriteLine($"Loop for: Iteração: {i}");
    i++;
}
Console.ReadKey();

/* Múltiplas expressões
Podemos usar várias expressões dentro de um loop FOR. Isso significa que podemos
ter mais de uma instrução de inicialização e/ou iterador dentro de um
loop for.


*/
for (int i = 0, j = 10; i + j <= 10; i++, j--)
{
    Console.WriteLine($"i = {i} e j = {j}");
}

Console.ReadKey();

/* Seções Opcionais
A inicialização, a condição e a instrução do iterador são opcionais
em um loop FOR e assim podemos executar um loop sem essas instruções.

*/

//1- Loop FOR sem definir a inicialização e a instrução de iteração.
int k = 1;
for (; k <= 5; )
{
    Console.WriteLine($"Loop FOR: Iteração: {k}");
    k++;
}
Console.ReadKey();

/* 2 Loop sem nenhuma seção (loop infinito)
int l=1;
for(;;){
    Console.WriteLine($"Loop Infinito: Iteração: {l}");
    l++;
}
*/

/* Loop FOR aninhado
Da mesma forma que os loops while e do-while, os loops FOR também podem ser

for(inicialização; condição; iteração){
    for(inicialização; condição; iteração){
        //bloco de instruções
    }
}
*/

Console.ReadKey();