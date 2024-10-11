using System;

class HealthIndicator
{
    static void Main()
    {
        Consocfbcle.Write("Введите ваш вес (в кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите ваш рост (в метрах): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите ваш возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine($"Ваш ИМТ (индекс массы тела): {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Рекомендация: недостаточный вес. Рекомендуется набрать вес.");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Рекомендация: нормальный вес. Продолжайте поддерживать ваше здоровье.");
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            Console.WriteLine("Рекомендация: избыточный вес. Рекомендуется уделить внимание диете и упражнениям.");
        }
        else
        {
            Console.WriteLine("Рекомендация: ожирение. Обратитесь к врачу для консультации.");
        }
    }
}
