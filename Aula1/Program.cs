// Aula 1 - Variáveis e leitura de dados
// Console.Write    -> escreve sem pular linha
// Console.ReadLine -> lê o que o usuário digita (sempre texto)
// int.Parse        -> converte texto em número
// ??               -> se vier nulo, usa o valor da direita


using System.Net.Mail;

Console.Write("Qual seu nome?");
string nome = Console.ReadLine();

Console.Write("Qual sua idade?");
int idade = int.Parse(Console.ReadLine());

int anoNascimento = 2026 - idade;

Console.WriteLine($"Ola, {nome}, bem vindo!");
Console.WriteLine($"Voce Nasceu por  volta dos {anoNascimento}");