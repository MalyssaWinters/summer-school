using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        //
        static string[] Students = new string[15];

        static int DisplayMenu()
        {
            Console.Clear();
            int menuChoice = 0;

            Console.WriteLine("Welcome to Hogwarts");
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option below");
            Console.WriteLine("1. Enroll Student");
            Console.WriteLine("2. Unenroll Student");
            Console.WriteLine("3. Print out the list of enrolled students");
            Console.WriteLine("4. Exit");

            menuChoice = Convert.ToInt32(Console.ReadLine());
            return menuChoice;
        }

        static void EnrollStudents()
        {
            Console.WriteLine("Enroll here");
        }

        static void UnenrollStudents()
        {
            Console.WriteLine("Unenroll here");
        }

        static void ListStudents()
        {
            Console.WriteLine("Print list of enrolled students here");
        }

        static void Main(string[] args)
        {
            int menuChoice = 0;
            while (menuChoice != 4)
            {
                menuChoice = DisplayMenu();
                if (menuChoice == 1)
                {
                    EnrollStudents();

                }
                if (menuChoice == 2)
                {
                    UnenrollStudents();
                }
                if (menuChoice == 3)
                {
                    ListStudents();
                }
                if (menuChoice == 4)
                {
                    break;
                }
                //
                Console.ReadKey();

            }
                                    
       }
    }
}
