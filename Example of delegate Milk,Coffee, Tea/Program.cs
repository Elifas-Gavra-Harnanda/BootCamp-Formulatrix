
public class Class1
	{
		public delegate void Vender();

		public static void Milk()
		{
			Console.Write("Milk + ");
		}

		public static void Tea()
		{
			Console.Write("Tea = Tea ");
		}

		public static void Coffee()
		{
			Console.Write("Coffee = Coffee ");
		}

		static void Main()
		{
			Vender vender = new Vender(Milk);
			Console.WriteLine("\t\tPress 1 For Tea\n\t\t Press 2 For Coffee");
			int Opt = Convert.ToInt32(Console.ReadLine());
			switch (Opt)
			{
				case 1:
					vender += Tea;
					break;

				case 2:
					vender += Coffee;
					break;

				default:
					Console.WriteLine("Invalid Option !");
					Environment.Exit(0);
					break;
			}

			vender();
			Console.ReadKey();
		}
	}