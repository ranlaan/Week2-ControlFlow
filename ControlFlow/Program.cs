using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem ku 18 siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oled 18"

            Console.WriteLine("Sisesta oma vanus.");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor");
            }
            else
            {
                Console.WriteLine("Oled 18.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
