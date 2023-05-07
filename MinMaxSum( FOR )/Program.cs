using System.Diagnostics.CodeAnalysis;
do
{
    Console.WriteLine("Моля въведете функция: (MinNumber MaxNumber Sum1 Sum2)");
    string func = Console.ReadLine();
    if (func == "MinNumber")
    {
        Console.WriteLine("Колко числа ще въведете?");
        int numberOfNumbers = int.Parse(Console.ReadLine());
        if (numberOfNumbers > 0)
        {
            int minN = int.MaxValue;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.WriteLine("Въведете следващото число:");
                int currentN = int.Parse(Console.ReadLine());
                if (currentN < minN)
                    minN = currentN;
            }
            Console.WriteLine($"Най-малкото от въведените числа е : {minN}");
        }
        else
            Console.WriteLine("Моля въведете валиден брой числа.");
    }
    else if (func == "MaxNumber")
    {
        Console.WriteLine("Колко числа ще въведете?");
        int numberOfNumbers = int.Parse(Console.ReadLine());
        if (numberOfNumbers > 0)
        {
            int maxN = int.MinValue;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.WriteLine("Въведете следващото число:");
                int currentN = int.Parse(Console.ReadLine());
                if (currentN > maxN)
                    maxN = currentN;
            }
            Console.WriteLine($"Най-голямото от въведените числа е : {maxN}");
        }
        else
            Console.WriteLine("Моля въведете валиден брой числа.");
    }
    else if (func == "Sum1")
    {
        Console.WriteLine("Колко числа ще въведете?");
        int numberOfNumbers = int.Parse(Console.ReadLine());
        if (numberOfNumbers > 0)
        {
            int sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.WriteLine("Въведете следващото число:");
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine($"Сумата на въведените числа е : {sum}");
        }
        else
            Console.WriteLine("Моля въведете валиден брой числа.");
    }
    else if (func == "Sum2") //sled "krai" sum2 se povtarq
    {
        int sum = 0;
        while (true)
        {
            Console.WriteLine("Въведете число:");
            string input = Console.ReadLine();
            if (input == "end")
            {
                Console.WriteLine("Край");
                break;
            }
            else 
            {
                int n = int.Parse(input);
                sum += n;
                Console.WriteLine($"Сумата на предишните числа е : {sum}");
            }
        }
    }
    else
        Console.WriteLine("Моля въведете правилна фукнция!");
}while (true);