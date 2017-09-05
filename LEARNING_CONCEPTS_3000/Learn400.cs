/// <summary>
/// Learning Anonymous Function
/// </summary>
namespace LEARNING_CONCEPTS.Learn400
{
	public delegate void MyDelegate1();
	public delegate void MyDelegate2(string text);
	public delegate string MyDelegate3(string text);

	public static class Program
	{
		public static void Main(string[] args)
		{
			// **************************************************
			MyDelegate1 myDelegate1 = delegate
			{
				System.Console.WriteLine("Hello, World!");
			};

			myDelegate1();
			// **************************************************

			// **************************************************
			MyDelegate2 myDelegate2 = delegate (string text)
			{
				System.Console.WriteLine(text);
			};

			myDelegate2("Hello, World!");
			// **************************************************

			// **************************************************
			MyDelegate3 myDelegate3 = delegate (string text)
			{
				string strReturnValue = text.ToUpper();

				System.Console.WriteLine(text);

				return (strReturnValue);
			};

			string strResult = myDelegate3("Hello, World!");

			System.Console.WriteLine("Result: {0}", strResult);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
