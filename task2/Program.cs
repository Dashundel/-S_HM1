//2) Найти максимальное из трех чисел
public class Task2
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи первое число: ");
		int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введи второе число: ");
		int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи третье число: ");
		int num3 = int.Parse(Console.ReadLine());

        int max = num1;
        if (max < num2) max = num2;
        if (max < num3) max = num3;

        Console.WriteLine("Макимальное число: " + max );
	}
}
