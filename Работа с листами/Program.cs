using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_листами
{
    class Program
    {
        static void Main(string[] args)
        {
            string contin1 = " ";
            int contin2 = 0;
            string contin3 = "хочу попробовать снова";

            List<int> NewList = new List<int>();
            while (contin3 == "хочу попробовать снова") {
                try {
                    Console.Clear();
                    Console.WriteLine("Введите число элементов, которые будут занесены в динамический массив: ");
                    int N = int.Parse(Console.ReadLine());

                    while (NewList.Count < N)
                    {
                        Console.Write("Элемент: ");
                        NewList.Add(int.Parse(Console.ReadLine()));
                    }

                    Console.Clear();
                    Console.WriteLine("Введеные элементы в динамический массив: ");
                    foreach (int El in NewList)
                    {
                        Console.Write(" " + El);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Хотите занести сумму двух введеных вами чисел в лист?:\nWrite Yes and No, Other from continue:");

                        contin1 = Console.ReadLine();
                        if (contin1.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            try
                            {
                                Console.WriteLine("Введите число 1:");
                                int OneNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите число 2:");
                                int TwoNumber = int.Parse(Console.ReadLine());
                                int summ = OneNumber + TwoNumber;
                                NewList.Add(summ);
                                Console.WriteLine("Элементы в динамический массиве с суммой: ");
                                foreach (int El in NewList)
                                {
                                    Console.Write(" " + El);
                                }

                            }
                            catch (SystemException)
                            {
                                Console.WriteLine("Вы ввели не число, хотите попробовать еще раз?\nДля этого наберите - хочу попробовать снова\nИли же Exit ");
                                contin3 = Console.ReadLine();
                                if (contin3 != "хочу попробовать снова" && contin3.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели некоректные данные. Для автоматического завершения программы нажмите любую клавишу");

                                }


                            }
                        }
                        else if (contin1.Equals("other", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine("Напишите какую операцию вы хотите сделать из перечисленных: \nВывести количество элементов динамического массива. Нажмите - 1\nВывести среднее для массива. Нажмите - 2 ");

                            contin2 = int.Parse(Console.ReadLine());
                            if (contin2 == 1)
                            {
                                Console.WriteLine("Количество элементов динамического массива составляет: ");
                                Console.WriteLine(NewList.Count);
                            }
                            else if (contin2 == 2)
                            {
                                Console.WriteLine("Вывести среднее для массива: ");
                                Console.WriteLine(NewList.Average());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели некорректную операцию");
                        }
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Вы ввели не число, хотите попробовать еще раз?\nДля этого наберите - хочу попробовать снова\nИли же Exit ");
                        contin3 = Console.ReadLine();
                        if (contin3 != "хочу попробовать снова" && contin3.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели некоректные данные. Для автоматического завершения программы нажмите любую клавишу");

                        }

                    }

                    Console.ReadKey();

                }
                catch (SystemException)
                {
                    Console.WriteLine("Вы ввели не число \nДля продолжения наберите - хочу попробовать снова или Exit ");
                    contin3 = Console.ReadLine();
                    if (contin3!= "хочу попробовать снова" && contin3.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Environment.Exit(0);
                    } else
                    {
                        Console.WriteLine("Вы ввели некоректные данные. Для автоматического завершения программы нажмите любую клавишу");
                        
                    }
                }
            }Console.ReadKey();
        }
    }
}
