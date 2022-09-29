Console.WriteLine("1. Игра угадай число ");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывести все делители числа");
Console.WriteLine("4. Выйти из программы");
Console.WriteLine("выберите программу, которую хотите запустить: ");
int k = 0;
while (k <= 3)
{
    int count = Convert.ToInt32(Console.ReadLine());
    k = count;
    if (count == 1)
    {
        Console.WriteLine("Это игра 'Угадай число'!!!");
        Console.WriteLine("Ваша задача угадать число");


        Random random = new Random();
        int gyl = random.Next(0, 101);

        while (true)
        {
            Console.WriteLine("Введите число от 0 до 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == gyl)
            {
                Console.WriteLine("Вы выиграли!!!!!");
                break;
            }
            else if (number > gyl)
            {
                Console.WriteLine("Нужно меньше");
            }
            else
            {
                Console.WriteLine("Нужно больше");
            }

        }
        Console.WriteLine("выберите программу, которую хотите запустить: ");
    }
    if (count == 2)
    {
        int[,] arr = new int[10, 10];
        int arr1;

        for (int i = 1; i < arr.GetLength(0); ++i)
        {
            for (int j = 1; j < arr.GetLength(1); ++j)
            {

                int sum = i * j;
                if (i == j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                else if (i > j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                else if (i < j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }

            }
            Console.WriteLine("\n\n");
        }

        Console.WriteLine("выберите программу, которую хотите запустить: ");
    }
    if (count == 3)
    {
        Console.Write("Введи число ");
        int i = int.Parse(Console.ReadLine());
        for (int a = 1; a <= i; a++)
        {
            if (i % a == 0) Console.Write("{0} ", a);
        }

        Console.WriteLine("выберите программу, которую хотите запустить: ");
    }
}
