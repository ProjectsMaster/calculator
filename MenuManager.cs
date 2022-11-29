using System;

namespace Calculator
{
    class MenuManager
    {
        public void Display() {
            Console.WriteLine("\n\t ==========================");
            Console.WriteLine("\n\t  Арифметичний калькулятор ");
            Console.WriteLine("\n\t ==========================");
            Console.WriteLine("\n\t      1 - Додавання        ");
            Console.WriteLine("\n\t      2 - Віднімання       ");
            Console.WriteLine("\n\t      3 - Множення         ");
            Console.WriteLine("\n\t      4 - Ділення          ");
            Console.WriteLine("\n\t      5 - Вихід            ");
            Console.WriteLine("\n\t ==========================");
        }

        public int GetChoice() {
            Console.Write("\n> Вкажіть номер потрібної Вам операції: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public bool AllowContinue() {
            Console.Write("\n> Продовжити (y/n)? - ");
            string allow = Console.ReadLine(); 
            return (allow == "y");
        }
    }
}