/*Console.Write("Ola, digite sua idade:  ");
int idade = int.Parse(Console.ReadLine() ?? "0");


//Console.WriteLine($"Sua idade é: {idade}");

if  (idade >= 18)
{
    Console.WriteLine("Voce é maior de idade");
}
else
{
    Console.WriteLine($"voce tem apenas {idade} anos, e ainda é menor de idade");
}
*/


Console.Write("Digite sua nota: ");
double nota = double.Parse(Console.ReadLine() ?? "0");

if (nota >= 7)
{
    Console.WriteLine("Aprovado!");
}
else if (nota >=5)
{
    Console.WriteLine("recuperacao!");

}
else
{
    Console.WriteLine("reprovado");
}