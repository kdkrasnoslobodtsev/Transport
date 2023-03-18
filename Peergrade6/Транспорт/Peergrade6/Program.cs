using System;
using System.IO;
using System.Text;
using EKRLib;

namespace Peergrade6
{
    /// <summary>
    /// Класс основной программы.
    /// </summary>
    class Program
    {
        static Random rnd = new Random();

        /// <summary>
        /// Точка входа.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            do
            {
                File.WriteAllText("../../../../Cars.txt", String.Empty, Encoding.Unicode);
                File.WriteAllText("../../../../MotorBoats.txt", String.Empty, Encoding.Unicode);
                Console.Clear();
                Console.WriteLine("Приветствую Вас!!!");
                Transport[] transp = new Transport[rnd.Next(6, 10)];
                for (int i = 0; i < transp.Length; ++i)
                {
                    int check = rnd.Next(0, 2);
                    bool flag;
                    if (check == 0)
                    {
                        flag = CreateCar(transp, ref i);
                    }
                    else
                    {
                        flag = CreateBoat(transp, ref i);
                    }
                    // Если не возникло исключение, заводим двигатель транспорта.
                    if (flag)
                    {
                        Console.WriteLine(transp[i].StartEngine());
                    }
                }
                OutputTransport(transp);
                Console.WriteLine("Для выхода нажмите Esc. Иначе - любую другую кнопку.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("До свидания!!!");
        }

        /// <summary>
        /// Создает случайное название модели.
        /// </summary>
        /// <returns>Случайное значение модели</returns>
        static string RandomModel()
        {
            string model = String.Empty;
            for (int i = 0; i < 5; ++i)
            {
                int check = rnd.Next(0, 2);
                if (check == 0)
                {
                    model += (char)(rnd.Next((int)'A', (int)'Z' + 1));
                }
                else
                {
                    model += (char)(rnd.Next((int)'0', (int)'9' + 1));
                }
            }
            return model;
        }

        /// <summary>
        /// Вывод транспорта в файлы.
        /// </summary>
        /// <param name="transp">Массив с транспортом</param>
        static void OutputTransport(Transport[] transp)
        {
            for (int i = 0; i < transp.Length; ++i)
            {
                if (transp[i] is Car)
                {
                    File.AppendAllText("../../../../Cars.txt", transp[i].ToString() + "\n", Encoding.Unicode);
                }
                if (transp[i] is MotorBoat)
                {
                    File.AppendAllText("../../../../MotorBoats.txt", transp[i].ToString() + "\n", Encoding.Unicode);
                }
            }
        }

        /// <summary>
        /// Добавляем в массив лодку.
        /// </summary>
        /// <param name="transp">Массив транспорта</param>
        /// <param name="iter">Позиция для вставки</param>
        static bool CreateBoat(Transport[] transp, ref int iter)
        {
            try
            {
                transp[iter] = new MotorBoat(RandomModel(), (uint)rnd.Next(10, 100));
            }
            catch (TransportException e)
            {
                Console.WriteLine(e.Message);
                --iter;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Добывляем в массив автомобиль.
        /// </summary>
        /// <param name="transp">Массив транспорта</param>
        /// <param name="iter">Позиция вставки</param>
        static bool CreateCar(Transport[] transp, ref int iter)
        {
            try
            {
                transp[iter] = new Car(RandomModel(), (uint)rnd.Next(10, 100));
            }
            catch (TransportException e)
            {
                Console.WriteLine(e.Message);
                --iter;
                return false;
            }
            return true;
        }
    }
}
