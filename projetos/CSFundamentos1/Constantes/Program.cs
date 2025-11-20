/*Constantes
Constantes são valores imutáveis que são conhecidos em tempo de compilação e não mudam
durante a execução do programa. 
Em C#, as constantes são declaradas usando a palavra-chave 'const' e devem ser
inicializadas no momento da declaração.

const int ANO = 12; // Declaração de uma constante inteira
const int MES=30, SEMANA=7, QUINZENA=15; // Declaração de múltiplas constantes

const int MESES_ANO = 12;
const int DIAS_ANO = 365;
const float DIAS_POR_MES = (float)DIAS_ANO / MESES_ANO; // Cálculo usando constantes


*/
Console.WriteLine("Constantes em C#");

const int ANO =12;
const int MES=30, SEMANA=7, QUINZENA=15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;
const float DIAS_POR_MES = (float)DIAS_ANO / MESES_ANO;

Console.WriteLine("Dias por mês: " + DIAS_POR_MES);

//Calcular a área e o perímetro de um círculo
double raio, perímetro, area;
const double PI = 3.14;

Console.Write("Digite o valor do raio do circulo: ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine("O perímetro do círculo é: " + perímetro);
Console.WriteLine("A área do círculo é: " + area);

Console.ReadKey();
