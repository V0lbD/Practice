// See https://aka.ms/new-console-template for more information



using System.Text.Json.Nodes;
using Practice.Domain;
using Lab1;

namespace Practice.Launcher.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student("Злобин", "Владимир", "Олегович", "М8О-213Б-21", "C#");
                Student student2 = new Student("Злобин", "Владимир", "Олегович", "М8О-213Б-21", "C#");
                Student student3 = new Student("Злобин", "Олег", "Владимирович", "М8О-211Б-21", "Go");
                string surname = "Злобин";

                Console.WriteLine(student1.ToString());
                
                Console.WriteLine(student1.Equals((object)student2));
                Console.WriteLine(student1.Equals(student3));
                Console.WriteLine(student1.Equals(surname));
                Console.WriteLine(student1.Equals("C#"));
                
                Console.WriteLine(student1.GetHashCode());

                Console.WriteLine(($"The {student1.SurnameValue} {student1.NameValue} {student1.PatronymicValue} student's course is {student1.CourseNumberValue}."));

                Student wrongStudent = new Student(null, null, null, null, null);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine($"{exception.Message}: Сlass field cannot be null!");
            }   
        }
    }
}