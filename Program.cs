﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program - Second big number in array");
            Console.WriteLine("How it works - 1 - predefined array");
            Console.WriteLine("Numbers in predefined array...");
            int[] numbers = { 1, 26, -50, 25, 13, 24, 22, -3 };
            DisplayArray(numbers);
            Console.WriteLine("Second big number in predefined array...-------------------------");
            FindSecondBigNumberInArray(numbers);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Numbers in random array...");
            //Создание объекта для генерации чисел
            int[] randomArray = GetRandomArray(12);
            DisplayArray(randomArray);
            Console.WriteLine("Second big number in random array...----------------------------");
            FindSecondBigNumberInArray(randomArray);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Numbers in user defined array...");
            int[] userArray = GetUserArray();
            DisplayArray(userArray);
            Console.WriteLine("Second big number in User array...------------------------------");
            FindSecondBigNumberInArray(userArray);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("------------------------END----ARRAY--------Press any key-------------");
            Console.ReadKey();




            Console.WriteLine("------------------------START----LIST--------------------");
            Console.WriteLine("-----------Working with spisok----------------");
            List<object> Spisok = new List<object>();
            Console.WriteLine("-----------Enter length of List  (Positive integer)----------------");
            int listLeght;
            string listLeghtUser = Console.ReadLine(); // Получили какую то строку                                                           // 
            bool a = int.TryParse(listLeghtUser, out listLeght);
            while (((a == false) || (listLeght <= 1)) == true)
            {
                Console.WriteLine("You must enter POSITIVE INTEGER value!!!");
                Console.WriteLine("Enter List Size...");
                listLeghtUser = Console.ReadLine();
                a = int.TryParse(listLeghtUser, out listLeght);
            }
            Console.WriteLine("Welldone!!!");
            Console.WriteLine("-----------Add DOUBLE or INTEGER NUMBERS IN LIST----------------");
            string userString;

            double listDouble;
            bool listDoubleBool;

            for (int i = 0; i < listLeght; i++)
            {
                Console.WriteLine($"Enter list element...{i + 1} - ");
                userString = Console.ReadLine();
                userString = userString.Replace(".", ",");

                listDoubleBool = double.TryParse(userString, out listDouble);

                while (listDoubleBool == false)
                {
                    Console.WriteLine($"ENTER DOUBLE OR INT NUMBER...{i + 1} - ");
                    userString = Console.ReadLine();
                    userString = userString.Replace(".", ",");
                    listDoubleBool = double.TryParse(userString, out listDouble);
                    
                }

                if (listDoubleBool == true)
                {
                    Spisok.Add(listDouble);
                }
                               
            }
            Console.WriteLine();
            Console.WriteLine("Unsorted LIST  -------------");
            Spisok.ForEach(value => Console.Write(" "+value+" "));
            Console.WriteLine();
            Spisok.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted LIST  -------------");
            Spisok.ForEach(value => Console.Write(" " + value + " "));
            Console.WriteLine();
            Console.WriteLine("Second big number in List is  -------------");
            Console.WriteLine($"Number  {Spisok[Spisok.Count-2]}");
            Console.WriteLine("------------------------END----LIST-----Press any key------");
            Console.ReadKey();
        }









        public static void DisplayArray(int[] array)
        {
            Console.WriteLine("-----");
            foreach (int i in array)
            {
                Console.Write(" " + i + " ");
            }
            Console.WriteLine("-----");

        }
        public static void FindSecondBigNumberInArray(int[] array)
        {
            var numbers = array;

            Console.WriteLine("UnSorted numbers in Array");
            DisplayArray(numbers);
            Array.Sort(numbers);// сортировка массива по возрастанию
            Console.WriteLine("-----");
            Console.WriteLine("-----");
            Console.WriteLine("Sorted numbers in Array are..");
            DisplayArray(numbers);
            Console.WriteLine("-----");
            Console.WriteLine("-----");
            Console.WriteLine("Second big number in array is " + numbers[numbers.Length - 2]);
            Console.WriteLine("----Press any key");
            Console.ReadKey();

        }
        public static int[] GetRandomArray(int size)
        {
            Random rnd = new Random();
            int[] randomArray = new int[size];
            for (int i = 0; i < size - 1; i++)
            {
                randomArray[i] = rnd.Next(-100, 100);
            }

            return randomArray;
        }
        public static int[] GetUserArray()
        {
            Console.WriteLine("Enter Array size...");
            int arraySize;
            string userStringArraySize = Console.ReadLine(); // Получили какую то строку                                                           // 
            bool a = int.TryParse(userStringArraySize, out arraySize);

            while (((a == false) || (arraySize <= 2)) == true)
            {
                Console.WriteLine("You must enter POSITIVE INTEGER value!!!");
                Console.WriteLine("Enter Array Size...");
                userStringArraySize = Console.ReadLine();
                a = int.TryParse(userStringArraySize, out arraySize);
            }

            Console.WriteLine("Welldone!!!");

            Console.WriteLine("---Enter array elements..---");
            int[] userArray = new int[arraySize];
            string element;
            bool p;
            int userArrayElement;

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter array element...{i + 1} - ");
                element = Console.ReadLine();
                p = int.TryParse(element, out userArrayElement);

                while (p == false)
                {
                    Console.WriteLine($"ENTER INTEGER NUMBER...{i + 1} - ");
                    element = Console.ReadLine();
                    p = int.TryParse(element, out userArrayElement);
                }

                userArray[i] = userArrayElement;
            }

            return userArray;

        }

    }
}