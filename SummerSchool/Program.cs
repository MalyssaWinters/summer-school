using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
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
        static int GetNextAvailableSpot()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        static void EnrollStudents()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Please enter student name");
            string newStudent = Console.ReadLine();
            int spot = GetNextAvailableSpot();
            Students[spot] = newStudent;
            Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £200");
            Console.WriteLine("Press enter to continue");
        }

        static void UnenrollStudents()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Enter student number to unenroll");
            ListStudents();
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            int studentMinusOne = studentNumber - 1;
            Console.WriteLine(Students[studentMinusOne] + " has been unenrolled");
            Console.WriteLine("Press enter to continue");
            Students[studentMinusOne] = null;
        }

        static void ListStudents()
        {
            Console.WriteLine(" ");
            for (int i = 0; i < Students.Length; i++)
            {
            Console.WriteLine(i + 1 + ". " + Students[i]);
            }
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
                else if (menuChoice == 2)
                {
                    UnenrollStudents();
                }
                else if (menuChoice == 3)
                {
                    ListStudents();
                }
                else if (menuChoice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Choose options 1-4.");
                    Console.WriteLine("Press enter to continue.");
                }
                Console.ReadKey();

            }

        }
    }
}
