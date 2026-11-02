Console.Write("Digite um numero: ");
int numero1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite outro numero: ");
int numero2 = int.Parse( Console.ReadLine() ?? "0");

int soma = numero1 + numero2;
int menos = numero1 - numero2;
int vezes = numero1 * numero2;


Console.WriteLine($"{numero1} + {numero2} = {soma}");
Console.WriteLine($"{numero1} - {numero2} = {menos}");
Console.WriteLine($"{numero1} * {numero2} = {vezes}");


if (numero2 != 0)
{
    double divisao = (double)numero1 / numero2;
    Console.WriteLine($"{numero1} / {numero2} = {divisao:F2}");
}
else
{
    Console.WriteLine("Não é possível dividir por zero.");
}