// Objetivo: Familiarizar-se com a verificação de intervalos numéricos. 

Console.WriteLine("Digite um número para descobrir se ele existe em nosso intervalo");
double num = double.Parse(Console.ReadLine());

// Descobrir se há o intervalo

if (num <= 100)
{
    Console.WriteLine($"O número está entre 1 e 100");
}

