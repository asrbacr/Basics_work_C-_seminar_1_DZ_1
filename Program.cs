Console.Write("Введите номер задачи для проверки: ");
int numTask = Convert.ToInt32(Console.ReadLine());

switch (numTask)
{
    case 2:
        Console.WriteLine("Задача на проверку большего числа среди 2-ух");
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("max = " + a);
        }
        else if (b > a)
        {
            Console.WriteLine("max = " + b);
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
        break;

    case 4:
        Console.WriteLine("Задача на проверку большего числа среди 3-ух");
        Console.Write("Введите первое число: ");
        int max = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int maxb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int maxc = Convert.ToInt32(Console.ReadLine());

        if (max < maxb)
        {
            max = maxb;
        }
        if (max < maxc)
        {
            max = maxc;
        }
        Console.WriteLine("Максимальное число " + max);
        break;

    case 6:
        Console.WriteLine("Задача для проверки является ли число чётным");
        Console.Write("Введите число для проверки: ");
        int ValueToCheck = Convert.ToInt32(Console.ReadLine());

        if (ValueToCheck % 2 == 0)
        {
            Console.WriteLine("Да, " + ValueToCheck + " - число чётное.");
        }
        else
        {
            Console.WriteLine("Нет, " + ValueToCheck + " - число нечётное.");
        }
        break;

    case 8:
        Console.WriteLine("Задача для построения диапозона чётных чисел от 1 до N");
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 1;

        Console.Write("Диапозон чётных чисел: ");
        while (count <= number)
        {
            if (count % 2 == 0)
            {
                Console.Write(count + ", ");
            }
            count++;
        }
        if (count == 1)
        {
            Console.Write("отсутсвует.");
        }
        break;

    default:
        Console.WriteLine("Можно ввести только номера 2, 4, 6 или 8.");
        break;
}