using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    
    class Program
    {
        static double[] StudentCost = new double[15];
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

            //while loop with exception converts entry with letter to an int and bring menu back up
            while(menuChoice < 1 || menuChoice > 4)
            {
                try
                {
                    string userChoice = Console.ReadLine();
                    menuChoice = Convert.ToInt32(userChoice);
                   // menuChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Choose options 1-4.");
                }
            }
           
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

        static int CountStudents()
        {
            int Count = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null)
                {
                    Count++;
                }
            }
            return Count;
        }

        static void EnrollStudents()
        {
            double cost = 200;
            Console.WriteLine(" ");
            Console.WriteLine("Please enter first and last name");
            string newStudent = Console.ReadLine();
           // var names = newStudent.Split(' ');
           // string firstName = names[0];
           //string lastName = names[1];
            int spot = GetNextAvailableSpot();

            //Students with the last name Malfoy are not to be admitted.
            //If someone tries to enroll a Malfoy, print out an error message and do not add the student to the list.
            if (newStudent.ToLower() == "malfoy")
            {
                Console.WriteLine("This student may not be admitted");
                Console.WriteLine("Press enter for main menu");
            }
            //Students with the name Potter get 50% off rate.
            else if (newStudent.ToLower() == "potter")
            {
                Students[spot] = newStudent;
                StudentCost[spot] = cost / 2;
                Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + cost / 2);
                Console.WriteLine("Press enter to continue");
            }
            //Students with name tom, riddle or voldemort get 'Red Alert!' statement
            else if (newStudent.ToLower() == "tom")
            {
                Console.WriteLine("RED ALERT! He who must not be named.");
                Console.WriteLine("Press enter for main menu");
            }

            else if (newStudent.ToLower() == "riddle")
            {
                Console.WriteLine("RED ALERT! He who must not be named.");
                Console.WriteLine("Press enter for main menu");
            }
            else if (newStudent.ToLower() == "voldemort")
            {
                Console.WriteLine("RED ALERT! He who must not be named.");
                Console.WriteLine("Press enter for main menu");
            }

            //Longbottom to be admitted free of charge if less than 10 students are enrolled.
            else if (newStudent.ToLower() == "longbottom")
            {

                if (CountStudents() < 10)
                {
                    Students[spot] = newStudent;
                    StudentCost[spot] =  cost * 0;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" +  cost * 0);
                    Console.WriteLine("Press enter to continue");
                }
                else
                {
                    Students[spot] = newStudent;
                    StudentCost[spot] = cost;
                    Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + cost);
                    Console.WriteLine("Press enter to continue");
                }
            }

            //Students with a last name that starts with the same letter as their first name receive a 10% discount.

           /* else if (firstName.First = lastName.First)
            {
                Students[spot] = newStudent;
                StudentCost[spot] = cost * .9;
                Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + cost * .9);
                Console.WriteLine("Press enter to continue");
            }
            */

            else
            {
                Students[spot] = newStudent;
                StudentCost[spot] = cost;
                Console.WriteLine(Students[spot] + " is now enrolled and will need to pay £" + cost);
                Console.WriteLine("Press enter to continue");
            }
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
                Console.WriteLine(i + 1 + ". " + Students[i] + " £" + StudentCost[i]);
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
