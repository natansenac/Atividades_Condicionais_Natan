// Objetivo: Compreender a lógica de permissões baseadas em condições. 
// Descrição: Crie um programa que pergunte a idade de uma pessoa e determine se ela pode votar (idade >= 16). Utilize uma condição if para exibir a mensagem correspondente. 
// Exemplo de Saída: "Você pode votar." ou "Você não pode votar." 

Console.WriteLine("Digite a sua idade para saber se está apto para votar nas próximas eleições.");
double idade = double.Parse(Console.ReadLine());

// Verificar se está apto para votar ou não

if (idade >= 16)
{
    Console.WriteLine($"Usuário pode votar na próxima eleição");
    
}

else 
{
    Console.WriteLine($"Usuário não pode votar na próxima eleição");

}
