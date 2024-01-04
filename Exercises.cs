using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class Exercises
{
    static void Main()
    {
        // Teste do Exercicio
        // ExerciseOne();
        // ExerciseTwo();
        // ExerciseThree();
        // ExerciseFour();
        // ExerciseFive();
        // ExerciseSix();
        ExerciseSeven();
    }

    public static void ExerciseOne()
    {
        Console.WriteLine("Exercicio 1 - Famoso Hello World");
        Console.WriteLine("Hello World!");
    }

    public static void ExerciseTwo()
    {
        string nomeUsuario;
        Console.WriteLine("Digite seu nome: ");
        nomeUsuario = Console.ReadLine();
        Console.WriteLine($"Olá, {nomeUsuario}");
    }

    public static void ExerciseThree()
    {
        string nome;
        decimal salario;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite seu salario: ");
        salario = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"Nome: {nome}\nSalario: {salario}");
    }

    public static void ExerciseFour()
    {
        int primeiroNumero, segundoNumero;
        Console.WriteLine("Digite o primeiro numero: ");
        primeiroNumero = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        segundoNumero = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"A soma entre {primeiroNumero} e {segundoNumero} é {primeiroNumero + segundoNumero}");
    }

    public static void ExerciseFive()
    {
        decimal primeiroNumero, segundoNumero, media;

        Console.WriteLine("Digite o primeiro numero: ");
        primeiroNumero = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        segundoNumero = Convert.ToDecimal(Console.ReadLine());
        media = (primeiroNumero + segundoNumero) / 2;
        Console.WriteLine($"A média entre {primeiroNumero} e {segundoNumero} é {media}");
    }

    public static void ExerciseSix()
    {
        int numero;

        Console.WriteLine("Digite um número: ");
        numero = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"O antecessor de {numero} é {numero - 1}\nO sucessor de {numero} é {numero + 1}");
    }

    public static void ExerciseSeven()
    {
        decimal numero;
        
        Console.WriteLine("Digite um número: ");
        numero = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"O dobro de {numero} é {numero * 2}\nA terça parte de {numero} é {(numero/3).ToString("0.00")}");
    }
}
