﻿using System;
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
            string[] studentEnrollment = new string[15];
            //put student in next available spot
            //to find next available spot, create method 
            //loop over spots until we see null
            Console.WriteLine("Enroll students here!");
            Console.WriteLine(" ");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Please enter your name");
                studentEnrollment[i] = Console.ReadLine();
                int spot = GetNextAvailableSpot();

                Students[spot] = studentEnrollment[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine("Class list:");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(studentEnrollment[i]);
            }
        }

        static void UnenrollStudents()
        {
            Console.WriteLine("Unenroll here");

        }

        static void ListStudents()
        {
            Console.WriteLine("Print the list of enrolled students here");
            Console.WriteLine(" ");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
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
                    Console.WriteLine("Please choose from the options below");
                    Console.WriteLine(" ");
                }
                Console.ReadKey();

            }

        }
    }
}