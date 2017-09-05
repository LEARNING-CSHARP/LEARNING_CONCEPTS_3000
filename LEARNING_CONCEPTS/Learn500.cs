/// <summary>
/// Learning Anonymous Function - Action & Func & Predicate
/// </summary>
namespace LEARNING_CONCEPTS.Learn500
{
	//public delegate void MyDelegate1();
	//public delegate void MyDelegate2(string text);
	//public delegate string MyDelegate3(string text);

	public static class Program
	{
		public static void Main(string[] args)
		{
			// **************************************************
			System.Action myDelegate1 = delegate
			{
				System.Console.WriteLine("Hello, World!");
			};

			myDelegate1();
			// **************************************************

			// **************************************************
			System.Action<string> myDelegate2 = delegate (string text)
			{
				System.Console.WriteLine(text);
			};

			myDelegate2("Hello, World!");
			// **************************************************

			// **************************************************
			System.Func<string, string> myDelegate3 = delegate (string text)
			{
				string strReturnValue = text.ToUpper();

				System.Console.WriteLine(text);

				return (strReturnValue);
			};

			string strResult = myDelegate3("Hello, World!");

			System.Console.WriteLine("Result: {0}", strResult);
			// **************************************************

			// **************************************************
			System.Predicate<string> myDelegate4 = delegate (string text)
			{
				System.Console.WriteLine(text);

				if (string.Compare(text, "Hello, World!", ignoreCase: true) == 0)
				{
					return (true);
				}
				else
				{
					return (false);
				}
			};

			bool blnResult = myDelegate4("Hello, World!");

			System.Console.WriteLine("Result: {0}", blnResult);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
