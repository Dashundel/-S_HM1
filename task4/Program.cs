//4) Показать последнюю цифру трёхзначного числа
public class Task4
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");
		int num = int.Parse(Console.ReadLine());
		if(num >= 100 && num < 1000) Console.WriteLine(num % 10);
		else Console.WriteLine("некорректное число");
	}
}	