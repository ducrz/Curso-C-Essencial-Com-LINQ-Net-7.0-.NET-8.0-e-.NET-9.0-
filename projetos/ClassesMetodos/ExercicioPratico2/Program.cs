/* Exercício Prático 2
g- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
use a palavra-chave this)
i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
vai retornar um double representando a velocidade máxima do carro
( Para calcular a velocidade multiplique a potencia por 1.75)
h- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
j- Explique o comportamento da palavra return

*/
using ClassesMetodos.ExercicioPratico2; 

Console.WriteLine("Exercício prático 2");

Carro carro1 = new Carro("Modelo X", "Montadora Y");
carro1.Potencia = 150;

double velocidadeMaxima = carro1.VelocidadeMaxima(carro1.Potencia);

Console.WriteLine($"Carro: {carro1.Modelo}, Montadora: {carro1.Montadora}, Potência: {carro1.Potencia} HP, Velocidade Máxima: {velocidadeMaxima} km/h");

/* h- Ao usar este construtor para criar objetos do tipo Carro, podemos inicializar os atributos Modelo e Montadora
diretamente no momento da criação do objeto. Isso facilita a criação de instâncias da classe Carro, garantindo que esses
atributos essenciais sejam definidos desde o início.

j- A palavra return é usada em um método para indicar o valor que deve ser retornado ao chamador do método. No
caso do método VelocidadeMaxima, o return retorna o valor calculado da velocidade máxima com base na potência fornecida.
*/
