/* Modificadores de acesso

São palarvas-chave usadas para especificar o acesso de um membro (campo, propriedade, método, etc)
ou de um tipo (classe, struct, etc)

public - o tipo ou membro pode ser acessado por qualquer outro código no mesmo assmebly ou
em outro assembly que faça referência ao assembly.

private- O tipo ou membro pode ser acessado somente pelo código na mesma class ou struct.

internal -O tipo ou membro pode ser acessado por qualquer código no mesmo assembly, mas não
de outro assembly.

protected - O tipo ou membro pode ser acessado por qualquer código no assembly no qual ele é
declarado ou de uma classe derivada em outro assembly.

file- Restringe o escopo e a visibilidade de um tipo de nível superior ao arquivo no qual ele for declarado.

Uma boa prática é limitar a visbilidade dos seus tipos e/ou membros restringindo-os a apenas
a quem precisa realmente acessar o tipo ou membro.

Valor padrão dos modificadores de acesso:

Classe- internal
Struct- internal
Interface- internal
Enum- internal
Métodos, Campos e Propriedades- private

*/
Console.WriteLine("Modificadores de acesso em C#");

MInhaClasse minhaClasse = new MInhaClasse();
MinhaStruct minhaStruct = new MinhaStruct();
MinhaEnum minhaEnum = MinhaEnum.opcao1;
Console.WriteLine(minhaEnum);
