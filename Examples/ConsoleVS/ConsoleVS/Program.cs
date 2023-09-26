using ListMaster;

namespace ConsoleVS
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayMaster am = new();
			for (int i = 0; i < (new Random().Next(0, 10)); i++)
			{
				am.Add(new Random().Next(0, 10));

			}

			for (int i = 0; i < am.GetCount(); i++)
			{
				Console.WriteLine(am.GetValue(i));

			}
		}
	}
}


