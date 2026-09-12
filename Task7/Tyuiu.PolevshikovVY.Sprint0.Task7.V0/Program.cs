using Tyuiu.PolevshikovVY.Sprint0.Task7.V0.Lib;


namespace Tyuiu.PolevshikovVY.Sprint0.Task7.V0;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #0 | Выполнил: Полевщиков В. Ю. | АСОиУб-26-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #0                                                              *");
        Console.WriteLine("* Тема : Создание итогового решения по спринту                           *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #0                                                             *");
        Console.WriteLine("* Выполнил:  Полевщиков В. Ю. | АСОиУб-26-1                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать консольную программу на C#, которая суммируетзначения двух    *");
        Console.WriteLine("* одинаковых масивов по длине                                            *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5};

        Console.WriteLine("Значение элементов массива №1");
        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.Write(arrayNums1[i] + ", ");
        }

        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5};

        Console.WriteLine("Значение элементов массива №2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AddtionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Сумма элементов массива ровна:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + ", ");
            } 
        }
        else
        {
            Console.WriteLine("Ошибка! Исходные массивы имеют разное колличество элементов:");
        }
        Console.ReadKey();


    }
}
