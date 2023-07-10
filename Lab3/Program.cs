// See https://aka.ms/new-console-template for more information

using Lab3;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var list = new List<int>();
                list.Add(1);
                list.Add(6);
                list.Add(3);
                list.Add(10);
                list.Add(-5);
                list.Sort();
                
                Console.WriteLine(list.ToString());
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