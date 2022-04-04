//5) Показать вторую цифру трёхзначного числа	
public class Task5
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");
		int num = int.Parse(Console.ReadLine());
		if(num >= 100 && num < 1000) 
		{
			int second_num = num % 100 / 10;
			Console.WriteLine("Вторая цифра: " + second_num);
		}
		else Console.WriteLine("некорректное число");
	}
    
}	
