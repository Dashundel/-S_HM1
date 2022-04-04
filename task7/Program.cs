//7) Удалить вторую цифру трёхзначного числа
public class Task7
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи трехзначное число: ");
		int num = int.Parse(Console.ReadLine());
		if(num >= 100 && num < 1000) 
		{	
			int first_num = num / 100;
			int second_num = num % 10;
			Console.WriteLine("После удаления второй цифры, получается: " + first_num + second_num);

		}
		else Console.WriteLine("некорректное число");
	}
}
