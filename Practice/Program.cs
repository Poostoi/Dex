using System;
using System.Runtime.CompilerServices;
using Task_3_6_7;
using System.Diagnostics;
using System.Threading;

namespace Practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Выберите задание(3,6,7): ");
            string x = Console.ReadLine();
            Program p = new Program();
            switch (x)
            {
                case "3":
                    p.OOP();
                    break;
                case "6":
                    p.BoxingUnboxing();
                    break;
                case "7":
                    p.BasketEnumerator();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод.");
                    break;
            }
        }

        private void OOP()
        {
            Birds fish = new Birds("hh");
            fish.Move();

            var anim = new Animals[] {new Fish("Jon"), new Birds("Don"), new Mammals("Shiki")};
            foreach (var an in anim)
            {
                an.Move();
            }
        }

        private void BoxingUnboxing()
        {
            Stopwatch myStopwatch = new Stopwatch();
            Stopwatch myStopwatch1 = new Stopwatch();

            int numberRepeat = 1000;


            int a = 1234567890;
            myStopwatch.Start();
            object o = a;
            myStopwatch.Stop();
            myStopwatch1.Start();
            a = (int) o;
            myStopwatch1.Stop();

            TimeSpan ts = myStopwatch.Elapsed;
            TimeSpan ts1 = myStopwatch1.Elapsed;
            Console.WriteLine("{0} секунд(упаковка), {1} секунд(распаковка)", ts.Milliseconds, ts1.Milliseconds);
        }

        private void BasketEnumerator()
        {
        }
    }
}