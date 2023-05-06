namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myNewPhone = PhoneFactory.BuildPhone();
            myNewPhone.Call();
        }
    }
}
