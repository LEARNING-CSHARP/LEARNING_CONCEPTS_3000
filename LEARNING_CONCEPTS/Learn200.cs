/// <summary>
/// Learning Delegate
/// </summary>
namespace LEARNING_CONCEPTS.Learn200
{
	public delegate string MyDelegate(string text);

	public static class Program
	{
		public static void Main(string[] args)
		{
			string strResult;

			// **************************************************
			MyDelegate myDelegate = SomeFunction1;

			myDelegate += SomeFunction2;
			myDelegate += SomeFunction3;

			strResult =
				myDelegate.Invoke("Hello, World (1)!");

			System.Console.WriteLine("Result: {0}", strResult);
			// **************************************************

			System.Console.WriteLine();

			// **************************************************
			myDelegate -= SomeFunction2;

			strResult =
				myDelegate.Invoke("Hello, World (2)!");

			System.Console.WriteLine("Result: {0}", strResult);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}

		public static string SomeFunction1(string text)
		{
			string strResult =
				string.Format("Some Function (1): {0}", text);

			System.Console.WriteLine(strResult);

			return (strResult);
		}

		public static string SomeFunction2(string text)
		{
			string strResult =
				string.Format("Some Function (2): {0}", text);

			System.Console.WriteLine(strResult);

			return (strResult);
		}

		public static string SomeFunction3(string text)
		{
			string strResult =
				string.Format("Some Function (3): {0}", text);

			System.Console.WriteLine(strResult);

			return (strResult);
		}
	}
}
