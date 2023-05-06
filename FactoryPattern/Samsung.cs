using System;
namespace FactoryPattern
{
	public class Samsung : IMobilePhones
	{
		public Samsung()
		{
		}

        public void Call()
        {
            Console.WriteLine($"Making call to sister now!");
        }
    }
}

