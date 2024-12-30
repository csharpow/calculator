
string[] operations = {"+", "-", "*", "/"};
double num1;
double num2;


System.Console.WriteLine("Введите число");

while (!double.TryParse(Console.ReadLine(), out num1))
{
    System.Console.WriteLine("Вы ввели не число, попробуйте снова");
 
}

while (true)
{
    System.Console.WriteLine("Выберите операцию");
    string InputOperation = Console.ReadLine();


    while (!Array.Exists(operations, op => op == InputOperation))
    {
        System.Console.WriteLine("Вы ввели неверную операцию, попробуйте снова");
        InputOperation = Console.ReadLine();
    }

    System.Console.WriteLine("Введите второе число:");

    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        System.Console.WriteLine("Вы ввели не число, попробуйте снова");
    
    }

    try
    {
        double result = InputOperation switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 / num2
        };
        System.Console.WriteLine($"Результат: {result}");
        num1 = result;
    }

    catch (DivideByZeroException)
    {
        System.Console.WriteLine("Ошибка: Деление на ноль невозможно. Попробуйте заново");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Ошибка {ex.Message}");
    }



    System.Console.WriteLine("\nВыберите опцию:");
    System.Console.WriteLine("1 - Очистить экран и завершить программу");
    System.Console.WriteLine("2 - Продолжить работу с результатом");

    ConsoleKeyInfo InputNumber = Console.ReadKey(true);

    if (InputNumber.Key == ConsoleKey.NumPad1 || InputNumber.Key == ConsoleKey.D1)
    {
        Console.Clear();
        break;
    }

    else if (InputNumber.Key == ConsoleKey.NumPad2 || InputNumber.Key == ConsoleKey.D2)
    {
        Console.Clear();
        continue;
    }
    
    else
    {
        System.Console.WriteLine("\nНеверная опция. Попробуйте снова");
    }
}






  
    

