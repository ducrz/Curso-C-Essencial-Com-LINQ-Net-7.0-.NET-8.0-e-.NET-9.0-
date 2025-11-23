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
Console.ReadKey();
