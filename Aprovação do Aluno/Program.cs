// Calcular a aprovação do aluno utilizando uma média aritmética 

Console.WriteLine("Digite a nota da atividade");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota do trabalho");
double nota2 = double.Parse(Console.ReadLine());

// Calcular a média
double média = (nota1 + nota2) / 2;
Console.Clear();

// Verificar a situação do aluno (se aprovado ou reprovado)

if (média >= 5)
{
    Console.WriteLine($"Aluno(a) Aprovado(a): MÉDIA: {média}");
}

else
{
    Console.WriteLine($"Aluno(a) Reprovado(a): MÉDIA: {média}");
}

