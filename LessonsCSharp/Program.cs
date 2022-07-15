using System;

namespace LessonsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name; //Огологуэмо змінну Нейм
            Console.WriteLine("Hello, Who are u?");
            Name = Console.ReadLine(); // Зчитуэмо інформацію від вводу користувача

            Console.WriteLine("How old are u?"); // Запитуємось у користувача
            int Age = Convert.ToInt32(Console.ReadLine());
            //Оголошуємо змінну int Age Цілочисленною ( натуральне число) та 
            //присвоюємо їй строку string яку вводять з консолі 
            //та Конвертуємо значення в Int 

            Console.WriteLine("Nice to meet u " + Name);
            Console.WriteLine($"Nice to fuck {Name}");
            Console.WriteLine("Nice to bitch {1} {0}", Name, Age); //string , 0 , 1 ,2 ,......,

            string IHaveNum = Convert.ToString(Age); // Явно перетворюэмо
            string IHaveNum2 = Age.ToString(); // Не Явно перетворюэмо


            Console.ReadKey();  //Pause;
        }
    }
    }
}
