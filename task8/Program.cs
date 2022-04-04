//8) Выяснить, кратно ли число заданному, если нет, вывести остаток.
public class Task8
{
	static void Main(string[] args)
	{	
		Console.WriteLine("Введи число кратности: ");
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Введи проверяемое число: ");
		int check_num = int.Parse(Console.ReadLine());
		
        int res = check_num % num ;

		if(res == 0) 
        {
            Console.WriteLine("кратно");
        }
		
		else Console.WriteLine("Остаток от деления: " + res);
           
	}
}
