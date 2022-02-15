using System;


namespace TSVPS_BubbleSort
{
    class Program
    {
        private static void BubbleSort(int[] elementsArray)
        {
            int temp = 0; 
            for (int correntElementIdx = 0; correntElementIdx < elementsArray.Length - 1; correntElementIdx++)
            {
                bool flag = true;
                for (int nextElementIdx = 0 ; nextElementIdx < elementsArray.Length - (correntElementIdx + 1); nextElementIdx++)
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
            Console.WriteLine("Введите кол-во элементов массива");
            int amountOfElements = int.Parse(Console.ReadLine());
            int[] elementsArray = new int[amountOfElements];
            Random randomElements = new Random();
            Console.WriteLine($"Не отсортироваванный массив на {amountOfElements} элементов");
            for (int i = 0; i < elementsArray.Length; i++)
            {
                elementsArray[i] = randomElements.Next(0, 100);
                Console.Write(elementsArray[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            BubbleSort(elementsArray);
            Console.WriteLine($"Отсортироваванный массив на {amountOfElements} элементов");
            for (int i = 0; i < elementsArray.Length; i++)
            {

                Console.Write(elementsArray[i]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
