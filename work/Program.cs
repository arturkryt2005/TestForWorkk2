using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество начальных огоньков (c1): ");
        int c1 = int.Parse(Console.ReadLine());

        Console.Write("Введите количество потухших огоньков для переработки (b1): ");
        int b1 = int.Parse(Console.ReadLine());

        int totalHours = CalculateTotalBurningHours(c1, b1);

        Console.WriteLine($"Общее количество часов горения: {totalHours}");
    }

    static int CalculateTotalBurningHours(int c1, int b1)
    {
        int totalHours = 0;
        int currentSparklers = c1;

        while (currentSparklers > 0)
        {
            totalHours += currentSparklers * 2;

            int burntSparklers = currentSparklers;

            currentSparklers = (burntSparklers / b1) * 2;

            if (burntSparklers < b1)
            {
                break;
            }
        }

        return totalHours;
    }
}
