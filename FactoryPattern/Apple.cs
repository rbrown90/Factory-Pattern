using System;
namespace FactoryPattern
{
	public class Apple : IMobilePhones
	{
		public Apple()
		{
		}

        public void Call()
        {
            Console.WriteLine($"Getting ready to make a call.");
        }
    }
}

