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
        // ExerciseSeven();
        // ExerciseEight();
        // ExerciseNine();
        // ExerciseTen();
        // ExerciseEleven();
        ExerciseTwelve();

    }

    public static void ExerciseOne()
    {
        Console.WriteLine("Exercicio 1 - Famoso Hello World");
        Console.WriteLine("Hello World!");
    }
    public static void ExerciseTwo()
    {
        Console.WriteLine("Digite seu nome: ");
        var nomeUsuario = Console.ReadLine();
        Console.WriteLine($"Olá, {nomeUsuario}");
    }
    public static void ExerciseThree()
    {
        decimal salario;

        Console.WriteLine("Digite seu nome: ");
        var nome = Console.ReadLine();

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
        Console.WriteLine($"O dobro de {numero} é {numero * 2}\nA terça parte de {numero} é {(numero / 3).ToString("0.00")}");
    }
    public static void ExerciseEight()
    {
        decimal metro;
        Console.WriteLine("Digite uma distancia em metros:");
        metro = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"A distancia de {metro}m convertida é de:");
        Console.WriteLine($@"{metro/1000}Km               {(metro*10).ToString("#.#")}dm");
        Console.WriteLine($@"{metro/100}Hm                {metro*100:.0}cm");
        Console.WriteLine($@"{metro/10}Dam               {metro*1000:F1}mm");
    }
    public static void ExerciseNine()
    {
        decimal real = 0, dolar = 0;

        Console.Write($"Digite o valor em real a ser convertido: R$");
        real = Convert.ToDecimal(Console.ReadLine()); 
        dolar = real / 4.87m;
        Console.WriteLine($"O valor de R${real:F2} convertido é ${dolar:F2}");

    }
    public static void ExerciseTen()
    {
        decimal largura, altura, area, tinta;

        Console.Write($"Digite a largura da parede a ser pintada:");
        largura = Convert.ToDecimal(Console.ReadLine()); 

        Console.Write($"Digite a altura da parede a ser pintada:");
        altura = Convert.ToDecimal(Console.ReadLine());

        area = largura * altura;
        tinta = area / 2.0m;

        Console.WriteLine($"É necessario usar {tinta:F2}l de tinta para pintar uma parede de {area:F2}m²");

    }
    public static void ExerciseEleven()
    {
        int A, B, C; 
        double delta;

        Console.Write($"Digite o valor de A:");
        A = Convert.ToInt16(Console.ReadLine()); 
        Console.Write($"Digite o valor de B:");
        B = Convert.ToInt16(Console.ReadLine()); 
        Console.Write($"Digite o valor de C:");
        C = Convert.ToInt16(Console.ReadLine());

        delta = Math.Pow(B, 2) - 4 * A * C;

        Console.Write($"Equação de delta {B}² - 4 * {A} * {C} = {delta}");

    }
    public static void ExerciseTwelve()
    {
        decimal preco;

        Console.Write($"Digite o Preço atual do produto:");
        preco = Convert.ToDecimal(Console.ReadLine()); 

        Console.Write($"O produto de R${preco} com desconto de 5% é R${preco * 0.95m}");
    }


}
