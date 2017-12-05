using System;

public class Program
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Hello World!");
		if (args != null)
		{
			Console.WriteLine("Args:");
			foreach(var arg in args)
			{
				Console.WriteLine(arg);
			}
		}
	}
}