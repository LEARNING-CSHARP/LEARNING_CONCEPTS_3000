/// <summary>
/// Learning Delegate
/// </summary>
namespace LEARNING_CONCEPTS.Learn100
{
	public delegate void MyDelegate(string text);

	public static class Program
	{
		public static void Main(string[] args)
		{
			// **************************************************
			MyDelegate myDelegate1 = new MyDelegate(SomeFunction);

			myDelegate1.Invoke("Hello, World (1)!");
			// **************************************************

			// نگارش ساده‌تر

			// **************************************************
			MyDelegate myDelegate2 = SomeFunction;

			myDelegate2("Hello, World (2)!");
			// **************************************************

			// **************************************************
			MyDelegate myDelegate3 = SomeFunction;

			myDelegate3 += SomeFunction;

			myDelegate3("Hello, World (3)!");
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}

		public static void SomeFunction(string text)
		{
			System.Console.WriteLine(text);
		}
	}
}
