//6) Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
public class Task6
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число от 10 до 99: ");
		int num = int.Parse(Console.ReadLine());
		if(num >= 10 && num < 100) 
		{	
			int first_num = num / 10;
			int second_num = num % 10;
			if (first_num < second_num) Console.WriteLine("Большая цифра: " + second_num);
			else if (first_num > second_num) Console.WriteLine("Большая цифра: " + first_num);
			else Console.WriteLine("Цифры равны ");

		}
		else Console.WriteLine("некорректное число");
	}
}	