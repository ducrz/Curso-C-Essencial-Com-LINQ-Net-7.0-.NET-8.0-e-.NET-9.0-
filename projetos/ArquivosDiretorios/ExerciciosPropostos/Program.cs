/* Arquivos , Streams e I/O


*/


/* 1- Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo
existe. Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem
informando que o arquivo não foi encontrado.

*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o caminho do arquivo: ");
        string caminhoArquivo = Console.ReadLine();

        if (File.Exists(caminhoArquivo))
        {
            DateTime dataCriacao = File.GetCreationTime(caminhoArquivo);
            Console.WriteLine($"O arquivo existe. Data de criação: {dataCriacao}");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}   

/* 2- Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de
origem e destino devem ser fornecidos pelo usuário.

*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o caminho do arquivo de origem: ");
        string caminhoOrigem = Console.ReadLine();      
        Console.Write("Digite o caminho do arquivo de destino: ");
        string caminhoDestino = Console.ReadLine();
        try
        {
            File.Copy(caminhoOrigem, caminhoDestino);
            Console.WriteLine("Arquivo copiado com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao copiar o arquivo: {ex.Message}");
        }
    }
}   

/*3- Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo
novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na
tela.

*/

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "exemplo.txt";

        // Criar e escrever no arquivo
        using (StreamWriter escritor = new StreamWriter(caminhoArquivo))
        {
            escritor.WriteLine("Primeira linha de texto.");
        }

        // Adicionar mais informações ao arquivo
        using (StreamWriter escritor = new StreamWriter(caminhoArquivo, true))
        {
            escritor.WriteLine("Segunda linha de texto.");
        }

        // Ler e exibir o conteúdo do arquivo
        using (StreamReader leitor = new StreamReader(caminhoArquivo))
        {
            string conteudo = leitor.ReadToEnd();
            Console.WriteLine("Conteúdo do arquivo:");
            Console.WriteLine(conteudo);
        }
    }
}   


/* 4- Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de
criptografia AES. Em seguida, salve o arquivo criptografado em um novo arquivo. O nome do arquivo de
origem e destino deve ser fornecido pelo usuário.

*/
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;  
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o caminho do arquivo de origem: ");
        string caminhoOrigem = Console.ReadLine();
        Console.Write("Digite o caminho do arquivo de destino: ");
        string caminhoDestino = Console.ReadLine();

        try
        {
            // Ler o conteúdo do arquivo de origem
            string conteudo = File.ReadAllText(caminhoOrigem);

            // Criptografar o conteúdo usando AES
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (FileStream fsDestino = new FileStream(caminhoDestino, FileMode.Create))
                {
                    // Escrever a IV no início do arquivo
                    fsDestino.Write(aes.IV, 0, aes.IV.Length);

                    using (CryptoStream cs = new CryptoStream(fsDestino, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter escritor = new StreamWriter(cs))
                    {
                        escritor.Write(conteudo);
                    }
                }
            }

            Console.WriteLine("Arquivo criptografado com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao criptografar o arquivo: {ex.Message}");
        }
    }
}   

/*  5- Escreva um programa que leia o conteúdo de um arquivo de imagem e converta-o para um arquivo de texto
usando o algoritmo de codificação Base64. Em seguida, salve o arquivo de texto em um novo arquivo. O
nome do arquivo de origem e destino deve ser fornecido pelo usuário.


*/

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o caminho do arquivo de imagem de origem: ");
        string caminhoOrigem = Console.ReadLine();
        Console.Write("Digite o caminho do arquivo de texto de destino: ");
        string caminhoDestino = Console.ReadLine();         
        try
        {
            // Ler o conteúdo do arquivo de imagem
            byte[] imagemBytes = File.ReadAllBytes(caminhoOrigem);

            // Converter para Base64
            string base64String = Convert.ToBase64String(imagemBytes);

            // Salvar o conteúdo em um arquivo de texto
            File.WriteAllText(caminhoDestino, base64String);

            Console.WriteLine("Arquivo de imagem convertido para Base64 e salvo com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao converter o arquivo: {ex.Message}");
        }
    }
}   


/* 6- Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a
classe Path.


*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do diretório: ");
        string caminhoDiretorio = Console.ReadLine();

        try
        {
            string[] arquivos = Directory.GetFiles(caminhoDiretorio);

            Console.WriteLine("Arquivos no diretório:");
            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(Path.GetFileName(arquivo));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao listar os arquivos: {ex.Message}");
        }
    }
}   



/* 7- Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe
DirectoryInfo.


*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do diretório: ");
        string caminhoDiretorio = Console.ReadLine();           
        try
        {
            DirectoryInfo diretorioInfo = new DirectoryInfo(caminhoDiretorio);
            DirectoryInfo[] subdiretorios = diretorioInfo.GetDirectories();

            Console.WriteLine("Subdiretórios no diretório:");
            foreach (DirectoryInfo subdiretorio in subdiretorios)
            {
                Console.WriteLine(subdiretorio.Name);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao listar os subdiretórios: {ex.Message}");
        }
    }
}   



/* 8- Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro
desse diretório usando a classe Directory e a classe Path.


*/
using System;               

using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do novo diretório: ");          
        string caminhoDiretorio = Console.ReadLine();           
        try
        {
            // Criar o novo diretório
            Directory.CreateDirectory(caminhoDiretorio);        
            Console.Write("Digite o nome do arquivo a ser criado dentro do diretório: ");
            string nomeArquivo = Console.ReadLine();           
            string caminhoArquivo = Path.Combine(caminhoDiretorio, nomeArquivo);           
            // Criar o arquivo dentro do novo diretório
            using (FileStream fs = File.Create(caminhoArquivo))
            {
                // Arquivo criado
            }
            Console.WriteLine("Diretório e arquivo criados com sucesso.");
        }
        catch (Exception ex)
        {       
            Console.WriteLine($"Erro ao criar o diretório ou arquivo: {ex.Message}");
        }
    }
}      


/* 9- Criar um programa que permita ao usuário copiar um arquivo de um diretório para outro usando a classe File
e a classe Path.


*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do arquivo de origem: ");          
        string caminhoOrigem = Console.ReadLine();       
        Console.Write("Digite o caminho do arquivo de destino: ");          
        string caminhoDestino = Console.ReadLine();           
        try
        {
            File.Copy(caminhoOrigem, caminhoDestino);
            Console.WriteLine("Arquivo copiado com sucesso.");
        }
        catch (Exception ex)
        {       
            Console.WriteLine($"Erro ao copiar o arquivo: {ex.Message}");
        }
    }
}   




/* 10- Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File
e a classe Path.


*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do arquivo de origem: ");          
        string caminhoOrigem = Console.ReadLine();     
        Console.Write("Digite o caminho do arquivo de destino: ");      
        string caminhoDestino = Console.ReadLine();          
        try
        {
            File.Move(caminhoOrigem, caminhoDestino);
            Console.WriteLine("Arquivo movido com sucesso.");
        }
        catch (Exception ex)
        {       
            Console.WriteLine($"Erro ao mover o arquivo: {ex.Message}");
        }       
    }
}



/* 11- Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a
classe DirectoryInfo e a classe Path.


*/

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {    
        Console.Write("Digite o caminho do diretório: ");
        string caminhoDiretorio = Console.ReadLine();   
        try
        {
            DirectoryInfo diretorioInfo = new DirectoryInfo(caminhoDiretorio);
            FileInfo[] arquivos = diretorioInfo.GetFiles("*", SearchOption.AllDirectories);

            Console.WriteLine("Arquivos no diretório e subdiretórios:");
            foreach (FileInfo arquivo in arquivos)
            {
                Console.WriteLine(arquivo.FullName);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao listar os arquivos: {ex.Message}");
        }
    }   
}


/* 12- Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a
classe DirectoryInfo e a classe Path.


*/

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do arquivo ou diretório a ser excluído: ");          
        string caminho = Console.ReadLine();           
        try
        {
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
                Console.WriteLine("Arquivo excluído com sucesso.");
            }
            else if (Directory.Exists(caminho))
            {
                Directory.Delete(caminho, true);
                Console.WriteLine("Diretório excluído com sucesso.");
            }   
            else
            {
                Console.WriteLine("O arquivo ou diretório não foi encontrado.");
            }
        }
        catch (Exception ex)
        {       
            Console.WriteLine($"Erro ao excluir o arquivo ou diretório: {ex.Message}");
        }
    }
}

/* 13- Criar um programa que renomeie um arquivo usando a classe File e a classe Path


*/
using System;   
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do arquivo a ser renomeado: ");         
        string caminhoAntigo = Console.ReadLine();      
        Console.Write("Digite o novo nome do arquivo (incluindo o caminho): ");
        string caminhoNovo = Console.ReadLine();           
        try
        {
            File.Move(caminhoAntigo, caminhoNovo);
            Console.WriteLine("Arquivo renomeado com sucesso.");
        }       
        catch (Exception ex)
        {       
            Console.WriteLine($"Erro ao renomear o arquivo: {ex.Message}");
        }
    }
}   


/* 14- Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e
subdiretórios, usando a classe Directory e a classe Path.

*/

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Digite o caminho do diretório: ");          
        string caminhoDiretorio = Console.ReadLine();           
        try
        {
            long tamanhoTotal = CalcularTamanhoDiretorio(caminhoDiretorio);
            Console.WriteLine($"Tamanho total do diretório: {tamanhoTotal} bytes");
        }
        catch (Exception ex)
        {       
            Console.WriteLine($"Erro ao calcular o tamanho do diretório: {ex.Message}");
        }
    }       
    static long CalcularTamanhoDiretorio(string caminhoDiretorio)
    {
        long tamanhoTotal = 0;
        string[] arquivos = Directory.GetFiles(caminhoDiretorio, "*", SearchOption.AllDirectories);
        foreach (string arquivo in arquivos)
        {
            FileInfo infoArquivo = new FileInfo(arquivo);
            tamanhoTotal += infoArquivo.Length;
        }
        return tamanhoTotal;
    }
}       

/* 15- Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe
DirectoryInfo e a classe Path.

*/
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {    
        Console.Write("Digite o caminho do diretório: ");       
        string caminhoDiretorio = Console.ReadLine();           
        try
        {
            DirectoryInfo diretorioInfo = new DirectoryInfo(caminhoDiretorio);
            FileInfo arquivoMaisRecente = null;     
            foreach (FileInfo arquivo in diretorioInfo.GetFiles())
            {
                if (arquivoMaisRecente == null || arquivo.LastWriteTime > arquivoMaisRecente.LastWriteTime)
                {
                    arquivoMaisRecente = arquivo;
                }
            }       
            if (arquivoMaisRecente != null)
            {
                Console.WriteLine($"O arquivo mais recente é: {arquivoMaisRecente.Name}");
            }
            else
            {
                Console.WriteLine("Nenhum arquivo encontrado no diretório.");
            }
        }
        catch (Exception ex)        
        {       
            Console.WriteLine($"Erro ao encontrar o arquivo mais recente: {ex.Message}");
        }
    }   
}   