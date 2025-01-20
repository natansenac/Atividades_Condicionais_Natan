﻿// Objetivo: Aplicar condições para cálculos. 
// Descrição: Escreva um programa que peça o valor de uma compra e  verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% no valor e mostre o valor final. Caso contrário, exiba o valor original. 
// Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original: [valor]

using System.ComponentModel.Design;

Console.WriteLine("Digite o valor da compra: ");
double valor = double.Parse(Console.ReadLine());
if (valor > 100) 
{
    double desconto = valor * 0.10;
    double valorFinal = valor - desconto;
    Console.WriteLine("Valor com desconto: " + valorFinal);
 } else { 
    Console.WriteLine("Valor original: " + valor);
}