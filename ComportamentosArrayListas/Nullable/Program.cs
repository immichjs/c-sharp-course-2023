namespace Nullable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double? x = null;
			double? y = 20;
			double a = x ?? 20;
			double b= y ?? 20;

			Console.WriteLine(x.GetValueOrDefault());
			Console.WriteLine(y.GetValueOrDefault());

			Console.WriteLine(x.HasValue);
			Console.WriteLine(y.HasValue);

			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}
}