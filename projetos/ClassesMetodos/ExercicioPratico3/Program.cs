/* Exercício Prático 3
l- Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
potencia e retorna um int representando o aumento de potencia.
(para aumentar a potência incremente 3 ao parâmetro recebido)
m- Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o
comportamento da passagem do argumento por valor
n- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
chamado potencia e retorna um int representando o aumento de potencia.
(para aumentar a potência incremente 5 ao parâmetro recebido)
o- Explique a sobrecarga de métodos
p- Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o
comportamento da passagem do argumento por referência.

*/
Console.WriteLine("Exercício Prático 3 - Classes e Métodos\n");

int potenciaValor = 10;
Console.WriteLine($"Valor inicial da potência (por valor): {potenciaValor}");
int novaPotenciaValor = AumentarPotencia(potenciaValor);
Console.WriteLine($"Nova potência retornada (por valor): {novaPotenciaValor}");
Console.WriteLine($"Valor da potência após chamada do método (por valor): {potenciaValor}\n");
/* Comportamento da passagem do argumento por valor:
 Quando um argumento é passado por valor, uma cópia do valor é feita e usada dentro
 do método. Portanto, qualquer modificação feita ao parâmetro dentro do método não afeta    
    o valor original fora do método. No exemplo acima, o valor de 'potenciaValor' permanece
    inalterado após a chamada do método AumentarPotencia. */

int potenciaReferencia = 10;
Console.WriteLine($"Valor inicial da potência (por referência): {potenciaReferencia}");
int novaPotenciaReferencia = AumentarPotencia(ref potenciaReferencia);
Console.WriteLine($"Nova potência retornada (por referência): {novaPotenciaReferencia}");
Console.WriteLine($"Valor da potência após chamada do método (por referência): {potenciaReferencia  }\n");
/* Comportamento da passagem do argumento por referência:
 Quando um argumento é passado por referência, o método recebe uma referência ao valor original.
 Portanto, qualquer modificação feita ao parâmetro dentro do método afeta o valor original fora do método.
 No exemplo acima, o valor de 'potenciaReferencia' é alterado após a chamada do método AumentarPotencia. */ 
// Método que aumenta a potência passando o argumento por valor
int AumentarPotencia(int potencia)  
{
    potencia += 3;
    return potencia;
}   
// Método que aumenta a potência passando o argumento por referência
int AumentarPotencia(ref int potencia)  
{
    potencia += 5;
    return potencia;
}       
/* Sobre a sobrecarga de métodos:
 A sobrecarga de métodos é um recurso que permite criar múltiplos métodos com o mesmo nome,
 desde que tenham assinaturas diferentes (diferente número ou tipo de parâmetros).
 Isso permite que o mesmo método possa ser utilizado de maneiras diferentes, dependendo dos
 argumentos fornecidos durante a chamada do método. No exemplo acima, temos duas versões do
 método AumentarPotencia: uma que aceita um parâmetro por valor e outra que aceita um parâmetro
 por referência.
 */     

