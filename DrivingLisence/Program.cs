using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            // programm teatab kasutajat, kas ta on piisavalt vana, et juhiluba saada (18)

            Console.WriteLine("Sisesta oma sünniaasta.");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, saad juhiload kätte.");
            }
            else
            {
                Console.WriteLine("oled liiga noor");
            }




        }
    }
}
