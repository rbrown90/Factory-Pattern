using System;
namespace FactoryPattern
{
	public class PhoneFactory
	{
		public static IMobilePhones BuildPhone()
		{
			Console.WriteLine($"What type of phone are you looking for?");
			var answer = Console.ReadLine();

			switch(answer.ToLower())
			{
				case "samsung":
					return new Samsung();

				case "apple":
					return new Apple();

				default:
					return new Samsung();
			}
		}
	}
}

