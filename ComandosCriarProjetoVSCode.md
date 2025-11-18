# VS Code e .NET CLI - Criar projeto e solução igual ao Visual Studio

Criar uma solução:

dotnet new sln -o <nome-solução>

Criar um projeto dentro da solução (entrar na pasta da solução)

dotnet new <nome_template> -o <nome_projeto>

Incluir o projeto criado na solução existente (a partir da pasta da solução)

dotnet sln <nome_solução>.sln add <pasta_projeto>/<arquivo>.csproj

Abrir o projeto no VS Code (estando na pasta da solução)

dotnet sln <nome_solução>.sln add <pasta_projeto>/<arquivo>.csproj

Estrutura utilizada nas aulas:

dotnet new sln -o MinhaSolução

dotnet new console -o MeuProjeto

No diretório MinhaSolução:

dotnet sln MinhaSolucao.sln add MeuProjeto/MeuProjeto.csproj

Para abrir diretamente no VS Code:

code .

