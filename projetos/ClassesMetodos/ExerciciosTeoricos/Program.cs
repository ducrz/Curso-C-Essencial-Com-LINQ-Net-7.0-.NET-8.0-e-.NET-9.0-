/* Exercicios Teóricos

1- O que é uma classe e qual a sua composição ?
Resposta: Uma classe é um molde ou um modelo que define as características e comportamentos de um objeto. Ela é composta por atributos (ou campos) que representam o estado do objeto e métodos que definem as ações que o objeto pode realizar.

2- O que é um objeto e como pode ser criado ?
Resposta: Um objeto é uma instância de uma classe, ou seja, é uma entidade concreta que possui as características e comportamentos definidos pela classe. Um objeto pode ser criado utilizando a palavra-chave "new" seguida do nome da classe e parênteses, por exemplo: ClasseNome objeto = new ClasseNome();

3- Qual a diferença entre classe e objeto ?
Resposta: A classe é o molde ou modelo que define as características e comportamentos de um objeto, enquanto o objeto é uma instância concreta dessa classe. A classe é uma definição abstrata, enquanto o objeto é uma entidade real que pode ser manipulada no programa.

4- O que é um método e como pode ser criado e chamado ?
Resposta: Um método é uma função ou procedimento que define uma ação ou comportamento que um objeto pode realizar. Ele pode ser criado dentro de uma classe utilizando a sintaxe de declaração de método, que inclui o tipo de retorno, o nome do método e os parâmetros (se houver). Um método pode ser chamado utilizando o nome do objeto seguido do operador ponto (.) e o nome do método, por exemplo: objeto.MetodoNome();

5- O que é um parâmetro de método ?
Resposta: Um parâmetro de método é uma variável que é definida na declaração de um método e que permite passar valores para o método quando ele é chamado. Os parâmetros são usados para fornecer informações adicionais ao método para que ele possa executar sua tarefa de forma adequada.

6- O que é um argumento ?
Resposta: Um argumento é o valor real que é passado para um método quando ele é chamado. Os argumentos correspondem aos parâmetros definidos na declaração do método e fornecem os dados necessários para que o método possa executar sua tarefa.

7- O que é um construtor e qual o seu objetivo ?
Resposta: Um construtor é um método especial dentro de uma classe que é chamado automaticamente quando um objeto da classe é criado. O objetivo do construtor é inicializar os atributos do objeto e configurar seu estado inicial. Ele geralmente tem o mesmo nome da classe e não possui um tipo de retorno.

8- Quais os usos da palavra chave this ?
Resposta: A palavra-chave "this" é usada dentro de uma classe para referenciar a instância atual do objeto. Ela pode ser usada para distinguir entre atributos da classe e parâmetros do método quando eles têm o mesmo nome, para chamar outros construtores dentro da mesma classe (construtor de encadeamento) e para passar a instância atual como um argumento para outros métodos.

9- O que é um método com retorno ?
Resposta: Um método com retorno é um método que retorna um valor após sua execução. Ele é definido com um tipo de retorno específico na declaração do método, e o valor retornado pode ser usado pelo código que chamou o método. Para retornar um valor, o método utiliza a palavra-chave "return" seguida do valor a ser retornado.

10- O que é sobrecarga de método ?
Resposta: Sobrecarga de método é um recurso que permite definir múltiplos métodos com o mesmo nome dentro de uma classe, desde que eles tenham assinaturas diferentes (ou seja, diferentes tipos ou números de parâmetros). Isso permite que o mesmo método possa ser chamado de maneiras diferentes, dependendo dos argumentos fornecidos.

11- Como é feita a passagem de parâmetros por valor ?
Resposta: A passagem de parâmetros por valor é feita quando uma cópia do valor do argumento é passada para o método. Isso significa que qualquer alteração feita ao parâmetro dentro do método não afeta o valor original do argumento fora do método. Em C#, os tipos primitivos (como int, float, bool) são passados por valor por padrão.

12- Como é feita a passagem de parâmetros por referência ?
Resposta: A passagem de parâmetros por referência é feita quando uma referência (ou endereço) do argumento é passada para o método, em vez de uma cópia do valor. Isso significa que qualquer alteração feita ao parâmetro dentro do método afeta o valor original do argumento fora do método. Em C#, isso pode ser feito usando a palavra-chave "ref" ou "out" na declaração do método e na chamada do método.

13- Qual a diferença entre os parâmetros out e o parâmetro ref ?
Resposta: A principal diferença entre os parâmetros "out" e "ref" é que os parâmetros "ref" devem ser inicializados antes de serem passados para o método, enquanto os parâmetros "out" não precisam ser inicializados antes da chamada do método, mas devem ser atribuídos dentro do método antes de serem usados. Ambos permitem a passagem por referência, mas "out" é usado quando o método precisa retornar múltiplos valores.

14- O que são argumentos nomeados ?
Resposta: Argumentos nomeados são uma funcionalidade que permite especificar os argumentos de um método pelo nome do parâmetro, em vez de pela ordem em que os parâmetros são definidos. Isso torna o código mais legível e permite que os argumentos sejam passados em qualquer ordem. Por exemplo: MetodoNome(parametro2: valor2, parametro1: valor1);

15- O que são parâmetros opcionais ?
Resposta: Parâmetros opcionais são parâmetros que possuem um valor padrão definido na declaração do método. Isso permite que o método seja chamado sem fornecer um valor para esses parâmetros, caso contrário, o valor padrão será usado. Parâmetros opcionais devem ser declarados após todos os parâmetros obrigatórios na assinatura do método.

16- Qual o efeito da palavra-chave static ?
Resposta: A palavra-chave "static" é usada para definir membros (atributos ou métodos) que pertencem à classe em si, em vez de a instâncias específicas da classe. Isso significa que membros estáticos podem ser acessados diretamente pela classe, sem a necessidade de criar um objeto da classe. Membros estáticos são compartilhados entre todas as instâncias da classe e podem ser usados para armazenar dados ou comportamentos que são comuns a todas as instâncias.

17- O que é método estático e qual o seu comportamento ?
Resposta: Um método estático é um método que pertence à classe em si, em vez de a uma instância específica da classe. Isso significa que ele pode ser chamado diretamente pela classe, sem a necessidade de criar um objeto da classe. O comportamento de um método estático é que ele não pode acessar membros de instância (não estáticos) da classe diretamente, pois não há uma instância associada a ele. Ele só pode acessar outros membros estáticos da classe.

18- O que é um campo estático e qual o seu comportamento ?
Resposta: Um campo estático é um atributo que pertence à classe em si, em vez de a uma instância específica da classe. Isso significa que ele é compartilhado entre todas as instâncias da classe e pode ser acessado diretamente pela classe, sem a necessidade de criar um objeto da classe. O comportamento de um campo estático é que ele mantém um único valor compartilhado por todas as instâncias da classe, e qualquer alteração feita ao campo estático afeta todas as instâncias.

19- O que são propriedades ?
Resposta: Propriedades são membros de uma classe que fornecem uma maneira controlada de acessar e modificar os valores dos campos privados da classe. Elas atuam como intermediárias entre os campos e o código externo, permitindo encapsulamento e validação dos dados. As propriedades geralmente possuem métodos "get" e "set" para ler e atribuir valores, respectivamente.

20- Qual a diferença entre campos e propriedades ?
Resposta: A principal diferença entre campos e propriedades é que os campos são variáveis diretamente acessíveis dentro da classe, enquanto as propriedades são membros que fornecem uma interface controlada para acessar e modificar os valores dos campos. As propriedades permitem encapsulamento, validação e lógica adicional ao acessar ou atribuir valores, enquanto os campos não possuem essa funcionalidade.

21- O que é uma struct ?
Resposta: Uma struct (estrutura) é um tipo de dado definido pelo usuário que agrupa variáveis relacionadas em um único tipo. Diferente das classes, as structs são tipos de valor, o que significa que quando uma struct é atribuída a uma nova variável ou passada para um método, uma cópia dos dados é feita. Structs são geralmente usadas para representar pequenos conjuntos de dados que não requerem a complexidade e os recursos das classes, como herança e polimorfismo.

22- Qual a diferença entre uma struct e uma classe ?
Resposta: A principal diferença entre uma struct e uma classe é que as structs são tipos de valor, enquanto as classes são tipos de referência. Isso significa que quando uma struct é atribuída a uma nova variável ou passada para um método, uma cópia dos dados é feita, enquanto para classes, apenas a referência ao objeto é copiada. Além disso, structs não suportam herança e são geralmente usadas para representar pequenos conjuntos de dados, enquanto classes são mais adequadas para objetos complexos que requerem recursos como herança e polimorfismo.

23- O que é uma Enum ?
Resposta: Uma Enum (enumeração) é um tipo de dado definido pelo usuário que consiste em um conjunto de constantes nomeadas. As Enums são usadas para representar um grupo de valores relacionados de forma mais legível e organizada, facilitando o código e melhorando a clareza. Cada valor em uma Enum é associado a um valor inteiro subjacente, começando por padrão em zero, mas pode ser explicitamente definido pelo programador.

24- Quais são e qual o escopo dos modificadores de acesso ?
Resposta: Os modificadores de acesso em C# são:
public: O membro é acessível de qualquer lugar.
private: O membro é acessível apenas dentro da própria classe.
protected: O membro é acessível dentro da própria classe e em classes derivadas.
internal: O membro é acessível apenas dentro do mesmo assembly (projeto).
protected internal: O membro é acessível dentro do mesmo assembly e em classes derivadas,

25- Qual a regra geral para usar os modificadores de acesso ?
Resposta: A regra geral para usar os modificadores de acesso é aplicar o princípio do menor privilégio, ou seja, restringir o acesso aos membros da classe ao mínimo necessário. Deve-se usar "private" por padrão para proteger os dados e comportamentos internos da classe, e somente expor membros como "public" ou "protected" quando for realmente necessário para a funcionalidade externa ou para herança. Isso ajuda a manter o encapsulamento e a integridade dos dados.

*/


