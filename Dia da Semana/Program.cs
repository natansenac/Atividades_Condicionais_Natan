// Objetivo: Praticar a utilização de múltiplas condições com if, else if e else. 
// Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
// Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7." 

using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Digite um dia da semana");
double dia = double.Parse(Console.ReadLine());

// Dia da Semana

if (dia == 1)
{
    Console.WriteLine("Domingo");
}
else if (dia == 2)
{
    Console.WriteLine("Segunda-feira");
}
else if (dia == 3)
{
    Console.WriteLine("Terça-feira");
}
else if (dia == 4)
{
    Console.WriteLine("Quarta-feira");
}
else if (dia == 5)
{
    Console.WriteLine("Quinta-feira");
}
else if (dia == 6)
{
    Console.WriteLine("Sexta-feira");
}
else if (dia == 7)
{
    Console.WriteLine("Sábado");
}

else
{
    Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
}
