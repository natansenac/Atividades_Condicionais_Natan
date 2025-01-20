// Objetivo: Aplicar condições para classificar dados. 
// Descrição: Desenvolva um programa que solicite a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Utilize if e else para mostrar a mensagem apropriada. 
// Exemplo de Saída: "Você é maior de idade." ou "Você é menor de idade." 

Console.WriteLine("Digite a sua idade");
double idade = double.Parse(Console.ReadLine());

// Calcular se é maior de idade ou não

if (idade >=18)
{
    Console.WriteLine($"Usuário é maior de idade");

}
else
{
    Console.WriteLine($"Usuário é menor de idade");

}

     