// =====================================================
// AULA 3 - Estruturas de repetição (for)
// =====================================================

/*
// -----------------------------------------------------
// Exercício 1 - Tabuada
// Pede um número e mostra a tabuada dele de 1 a 10.
// Conceitos: for, multiplicação, interpolação de texto
// -----------------------------------------------------
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
*/

/*
// -----------------------------------------------------
// Exercício 2 - Contagem regressiva
// Conta de 10 até 1 e mostra "Fogo!" no final.
// Conceitos: for decrescente, decremento (i--)
// -----------------------------------------------------
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Fogo!");
*/

/*
// -----------------------------------------------------
// Exercício 3 - Contagem de 2 em 2
// Conta de 0 até 100, pulando de 2 em 2.
// Conceitos: atribuição composta (i += 2)
// -----------------------------------------------------
for (int i = 0; i <= 100; i += 2)
{
    Console.WriteLine(i);
}
*/

/*
// -----------------------------------------------------
// Exercício 4 - Contagem até o número informado
// Conta de 1 até o número digitado pelo usuário.
// Conceitos: variável na condição do for, incremento (i++)
// -----------------------------------------------------
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= numero; i++)
{
    Console.WriteLine($"Contando: {i}");
}
*/

/*
// -----------------------------------------------------
// Exercício 5 - Par ou ímpar de 0 a 20
// Mostra, para cada número de 0 a 20, se é par ou ímpar.
// Conceitos: if/else dentro do for, operador resto (%)
// -----------------------------------------------------
for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} é par");
    }
    else
    {
        Console.WriteLine($"{i} é ímpar");
    }
}
*/

// -----------------------------------------------------
// Exercício 6 - Pares até o número informado
// Mostra os pares de 2 até o número digitado e diz
// se o próprio número é par ou ímpar.
// Conceitos: for com passo 2 (i += 2), if/else, operador %
// -----------------------------------------------------
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Os números pares até {numero} são:");
for (int i = 2; i <= numero; i += 2)
{
    Console.WriteLine(i);
}

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par.");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}