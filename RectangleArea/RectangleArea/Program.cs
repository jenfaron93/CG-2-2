using System;

namespace RectangleArea
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Area of a rectangle");
			Console.Write("Please enter a length: ");
			string length = Console.ReadLine();

			Console.Write("Please enter a width: ");
			string width = Console.ReadLine();

			int area = Convert.ToInt32(length) * Convert.ToInt32(width);

			Console.WriteLine("The area of your rectangle is " + area + ".");
			Console.ReadLine();




        }
    }
}
