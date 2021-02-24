using System;
using System.Runtime.CompilerServices;
using Task_3_6_7;
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
                    p.Task_3();
                    break;
                case "6":
                    p.Task_6();
                    break;
                case "7":
                    p.Task_7();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод.");
                    break;
            }

            Console.ReadKey();
        }
        private void Task_3()
        {
            Birds fish = new Birds("hh");
            fish.Move();
            
            var anim = new Animals[] {new Fish("Jon"), new Birds("Don"), new Mammals("Shiki")};
            foreach (var an in anim)
            {
                an.Move();
            }
        }

        private void Task_6()
        {
        }
        private void Task_7()
        {
        }
    }
}