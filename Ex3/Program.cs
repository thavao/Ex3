//3 - faça um programa que leia a idade de uma pessoa e informe se ela é maior ou menor de idade

int idade;

Console.Write("Digite a idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 18)
    Console.WriteLine("Menor de idade");

else 
    Console.WriteLine("Maior de idade");