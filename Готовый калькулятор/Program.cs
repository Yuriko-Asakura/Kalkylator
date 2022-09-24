while (true)
{
    double a;
    double b;
    double res;
    char oper;

    Console.WriteLine("Выберите один из операторов:\n 1-сложение;\n 2-вычитание; \n 3-умножение; \n 4-деление; " +
       "\n 5-квадратный корень из а и b;" +
       "\n 6-возведение а в степень b;" +
       "\n 7- найти 1 процент от числа а и b;" +
       "\n 8-найти факториал из числа;" +
       "\n если выйти то 9.");
    oper = Convert.ToChar(Console.ReadLine());
   if (oper == '9')
    {
        Console.WriteLine("Вы вышли из калькулятора");
        break;
    }
    Console.WriteLine("Введите а:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите b:");

    b = Convert.ToDouble(Console.ReadLine());

     if (oper == '1')
    {
        res = a + b;
        Console.WriteLine("Результат сложения a+b= " + res + ".");
    }
    else if (oper == '2')
    {
        res = a - b;
        Console.WriteLine("Результат вычитания a-b= " + res + ".");
    }
    else if (oper == '3')
    {
        res = a * b;
        Console.WriteLine("Результат умножения a*b= " + res + ".");
    }
    else if (oper == '4')
    {
        res = a / b;
        Console.WriteLine("Результат деления a : b= " + res + ".");
    }
    else if (oper == '5')
    {
        double d = Math.Sqrt(a);
        double f = Math.Sqrt(b);
        Console.WriteLine("Корень из числа а = " + d + " и корень из числа b = " + f + ".");
    }
    else if (oper == '6')
    {
        double res_b = 1;
        for (double i = 0; i < b; i++)
        {
            res_b *= a;
        }
        Console.WriteLine("Результат возведение {0} в степень {1} = {2}", a, b, res_b);
    }
    else if (oper == '7')
    {
        double res_a = a;
        double res_b = b;
        res_a = res_a / 100;
        res_b = res_b / 100;
        Console.WriteLine("Результат нахождения от числа А одного процента = " + res_a + " и от числа b = " + res_b + ".");
    }
    else if (oper == '8')
    {
        double ress = b;
        for (double i = b; i <= a; i++)
        {
            ress = ress * i;
        }
        Console.WriteLine("Результат факториала: где а кол-во циклов, а b значение факториала = " + ress + ".");
    }
} 
