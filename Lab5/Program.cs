using Lab5;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }   
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}