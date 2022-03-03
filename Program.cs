using System;
using System.Collections.Generic;

namespace TSVPS_BubbleSort
{
    class Program
    {
        private static List<int> elementsArray = new List<int>();

        private static void Print()
        {
            for (int i = 0; i < elementsArray.Count; i++)
            {
                Console.Write($"{elementsArray[i]} ");
            }
        }

        private static void GetRandomElements(int amountOfElements)
        {
            Random randomElements = new Random();
            for (int i = 0; i < amountOfElements; i++)
            {
                elementsArray.Add(randomElements.Next(0, 100));
            }
        }

        private static void BubbleSort()
        {
            int temp = 0; 
            for (int correntElementIdx = 0; correntElementIdx < elementsArray.Count - 1; correntElementIdx++)
            {
                bool flag = true;
                for (int nextElementIdx = 0 ; nextElementIdx < elementsArray.Count - (correntElementIdx + 1); nextElementIdx++)
                {  
                    if (elementsArray[nextElementIdx] > elementsArray[nextElementIdx + 1])
                    {
                        temp = elementsArray[nextElementIdx + 1];
                        elementsArray[nextElementIdx + 1] = elementsArray[nextElementIdx];
                        elementsArray[nextElementIdx] = temp;
                        flag = false;
                    }
                }
                if (flag)
                {
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка массива методом BubbleSort");
            Console.Write("Введите кол-во элементов массива: ");
            int amountOfElements = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nНе отсортироваванный массив на {amountOfElements} элементов");
            GetRandomElements(amountOfElements);
            Print();
            Console.WriteLine();

            BubbleSort();

            Console.WriteLine($"Отсортироваванный массив на {amountOfElements} элементов");
            Print();
            Console.ReadLine();
        }
    }
}
