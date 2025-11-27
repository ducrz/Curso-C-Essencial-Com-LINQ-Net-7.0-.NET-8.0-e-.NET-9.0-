/* Exercício Prático 5

t- Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora,
Marca, Potencia e Ano e que exiba as informações destes atributos no console.
u- Para este método defina o parâmetro Ano como opcional e faça duas chamadas ao método usando o
conceito de argumentos nomeados não informando o ano na primeira chamada e informando o ano na segunda
chamada.
v- Explique o uso do parâmetro opcional e dos argumentos nomeados

*/
Console.WriteLine("Exercício Prático 5");
ExibirInfo("Palio", "Fiat", "Hatch", 65);
ExibirInfo("Argo Trekking", "Fiat", "Hatch", 107, ano: 2023);

static void ExibirInfo(string modelo, string montadora, string categoria, int potencia, int ano = 0)
{
    Console.WriteLine($"Modelo: {modelo}, Montadora: {montadora}, categoria: {categoria}, Potência: {potencia}cv, Ano: {(ano == 0 ? "Não informado" : ano.ToString())}");
}       
/* Explicação:
O parâmetro opcional "ano" permite que o método  seja chamado sem a necessidade de fornecer um valor para esse parâmetro.

Se o valor não for fornecido, ele assume o valor padrão de 0, que é tratado na exibição como "Não informado".

Os argumentos nomeados permitem que os argumentos sejam passados para o método especificando o nome do parâmetro,
o que melhora a legibilidade do código e permite a omissão de parâmetros opcionais, como demonstrado na primeira chamada do método.     

*/