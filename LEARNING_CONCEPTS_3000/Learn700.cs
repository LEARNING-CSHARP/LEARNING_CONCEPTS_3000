/// <summary>
/// Learning Lambda Expression
/// </summary>
namespace LEARNING_CONCEPTS.Learn700
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			// **************************************************
			System.Func<int, int> myDelegate1 = (x) => { int y = x + 5; return (y); };

			int intResult1 = myDelegate1(10);

			System.Console.WriteLine("Result: {0}", intResult1);
			// **************************************************

			// **************************************************
			System.Func<int, int> myDelegate2 = (x) => x + 5;

			int intResult2 = myDelegate2(10);

			System.Console.WriteLine("Result: {0}", intResult2);
			// **************************************************

			// **************************************************
			// Note: You can remove (), if you have just one variable!
			System.Func<int, int> myDelegate3 = x => x + 5;

			int intResult3 = myDelegate3(10);

			System.Console.WriteLine("Result: {0}", intResult3);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
