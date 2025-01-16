// Praticar a comparação entre números

Console.WriteLine("Digite o primeiro número");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
double num2 = double.Parse(Console.ReadLine());

// Fazer o Comparativo

if (num1 > num2)
{
    Console.WriteLine("O primeiro número é maior");
}

else if (num1 < num2)
{
    Console.WriteLine("O segundo número é maior");
}

else
{
    Console.WriteLine("Os números inseridos são iguais");
}