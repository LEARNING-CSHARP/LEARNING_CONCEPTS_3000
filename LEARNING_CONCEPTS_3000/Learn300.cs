/// <summary>
/// Learning Anonymous Function
/// </summary>
namespace LEARNING_CONCEPTS.Learn300
{
	public delegate void MyDelegate(string text);

	public static class Program
	{
		public static void Main(string[] args)
		{
			// **************************************************
			MyDelegate myDelegate = delegate (string text)
			{
				System.Console.WriteLine(text);
			};

			myDelegate("Hello, World!");
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}

		//public static void SomeFunction(string text)
		//{
		//	System.Console.WriteLine(text);
		//}
	}
}
