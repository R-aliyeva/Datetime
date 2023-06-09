using System.Globalization;

namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
       string date=Console.ReadLine();
            try { DateTime dateTime = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(dateTime);
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}