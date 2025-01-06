using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite o primeiro numero");
        string entrada1 = Console.ReadLine();    
       double numero1 = double.Parse(entrada1);

        Console.WriteLine("digite o segundo numero");
        string entrada2 = Console.ReadLine();
        double numero2 = double.Parse(entrada2);

        Console.WriteLine("escolha a operação (+, -, *, /):");
        string operacao = Console.ReadLine();

        double resultado = 0;

        if (operacao == "+")
        {
            resultado = numero1 + numero2;
        }
        else if (operacao == "-")
        {
            resultado = numero1 - numero2;
        }
        else if (operacao == "*")
        {
            resultado = numero1 * numero2;
        }
        else if (operacao == "/")
        {
            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("divisão por 0 não é permitida.");
                return;
            }
        }
        else
        {
            Console.WriteLine("operação inválida.");
            return;
        }

        Console.WriteLine("resultado: " + resultado);
    }
}