using System;

namespace LessonsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name; //Огологуэмо змінну Нейм
            Console.WriteLine("Hello, Who are u bitches?");
            Name = Console.ReadLine(); // Зчитуэмо інформацію від вводу користувача

            Console.WriteLine("How old are u MILFS?");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nice to meet u " + Name);
            Console.WriteLine($"Nice to fuck {Name}");
            Console.WriteLine("Nice to bitch {1} {0}", Name, Age); //string , 0 , 1 ,2 ,......,

            string IHaveNum = Convert.ToString(Age); // Явно перетворюэмо
            string IHaveNum2 = Age.ToString(); // Не Явно перетворюэмо


            Console.ReadKey();  //Pause;
        }
    }
}
