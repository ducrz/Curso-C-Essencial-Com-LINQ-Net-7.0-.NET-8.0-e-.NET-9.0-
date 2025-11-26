/* Exercício Prático 4
r- Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai
retornar a nova velocidade como um double.
(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
s- Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o
comportamento do parâmetro out.


*/
Console.WriteLine("Exercício Prático 4");

int potenciaAtual = 100;
double velocidadeAtual = 175.0;
int novaPotencia = AumentarPotenciaVelocidade(potenciaAtual, out double novaVelocidade);
Console.WriteLine($"Nova Potência: {novaPotencia}");
Console.WriteLine($"Nova Velocidade: {novaVelocidade} km/h");
int AumentarPotenciaVelocidade(int potencia, out double velocidade)
{
    potencia += 7;
    velocidade = potencia * 1.75;
    return potencia;
}
/* Explicação do comportamento do parâmetro out:
O parâmetro out permite que um método retorne múltiplos valores. No exemplo acima, o método AumentarPotenciaVelocidade
retorna a nova potência como valor de retorno do método e a nova velocidade através do parâmetro out.
Isso significa que, ao chamar o método, podemos obter tanto a nova potência quanto a nova velocidade, 
mesmo que o método só tenha um valor de retorno explícito. O parâmetro out deve ser inicializado dentro do método antes de
ser retornado, garantindo que ele sempre tenha um valor válido quando o método for concluído. 

*/


