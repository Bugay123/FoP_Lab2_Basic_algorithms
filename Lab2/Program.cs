internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Обчислити добуток трьох цілих чисел. Числа ввести з консолі. Результат вивести на консоль.
        Console.WriteLine("Завдання 1");
        Console.WriteLine("Введіть перше число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть третє число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Добуток трьох цілих чисел = " + num1 * num2 * num3);
        Thread.Sleep(3000);
        Console.Clear();

        //2. Обчислити довжину і площу кола за вказаним радіусом. Результат вивести на консоль.
        Console.WriteLine("Завдання 2");
        Console.WriteLine("Введіть радіус кола: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double l = Math.Round(2 * 3.14 * r, 2);
        double S = Math.Round(3.14 * (r * r), 2);
        Console.WriteLine("Довжина кола = " + l);
        Console.WriteLine("Площа кола = " + S);
        Thread.Sleep(3000);
        Console.Clear();

        //3.Знайти значення поліному p = 23,5 * x * x + 30 * x + 87,3.Значення x ввести з консолі. Результат вивести на консоль.
        Console.WriteLine("Завдання 3");
        Console.WriteLine("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double p = 23.5 * x * x + 30 * x + 87.3;
        Console.WriteLine("Значення поліному p = " + p);
        Thread.Sleep(3000);
        Console.Clear();

        //4.Обчислити площу прямокутного трикутника за заданими катетами. Результат вивести на консоль.
        Console.WriteLine("Завдання 4");
        Console.WriteLine("Введіть катет a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть катет b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double Sq = Math.Round(((a * b) / 2), 2);
        Console.WriteLine("Площа прямокутного трикутника: " + Sq);
        Thread.Sleep(3000);
        Console.Clear();

        //5.Обчислити остачу від ділення двох цілих чисел.
        Console.WriteLine("Завдання 5");
        Console.WriteLine("Введіть перше число: ");
        int numb1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге число: ");
        int numb2 = Convert.ToInt32(Console.ReadLine());
        int rest = numb1 % numb2;
        Console.WriteLine("Остача від ділення: " + rest);
    }
}