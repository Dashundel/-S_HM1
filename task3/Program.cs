//3) Выяснить является ли число чётным
public class Task3
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");
		int num = int.Parse(Console.ReadLine());
		if(num % 2 == 0) Console.WriteLine("четное ");
		else Console.WriteLine("не четное");
	}
}
