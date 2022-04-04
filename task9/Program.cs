//9) Найти третью цифру числа или сообщить, что её нет
public class Task9
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");
        string num1 = Console.ReadLine();

        if(num1.Length < 3 ) Console.WriteLine("В числе нет 3-ей цифры");
        else Console.WriteLine("Третья цифра: " + num1[2]);
	}
}
