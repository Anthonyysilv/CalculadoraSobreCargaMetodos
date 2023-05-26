using System;

class Calculadora
{
    public double operacao(double num1, double num2)
    {
        return num1 + num2;
    }

    public double operacao(int num1, double num2)
    {
        return num1 - num2;
    }

    public double operacao(double num1, int num2)
    {
        return num1 * num2;
    }

    public double operacao(int num1, int num2)
    {
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        Console.Write("Informe a operação (+, -, *, /): ");
        string operacao = Console.ReadLine();

        Console.Write("Informe o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        switch (operacao)
        {
            case "+":
                Console.WriteLine($"{num1} + {num2} = {calc.operacao(num1, num2)}");
                break;
            case "-":
                Console.WriteLine($"{num1} - {num2} = {calc.operacao((int)num1, num2)}");
                break;
            case "*":
                Console.WriteLine($"{num1} * {num2} = {calc.operacao(num1, (int)num2)}");
                break;
            case "/":
                Console.WriteLine($"{num1} / {num2} = {calc.operacao((int)num1, (int)num2)}");
                break;
            default:
                Console.WriteLine("Operação inválida!");
                break;
        }
    }
}