using System;

namespace Task_3_6_7
{
    public class Fish: Animals
    {
        public Fish(string name):base(name){}
        public  void  Move()
        {
            base.Move();
            Console.WriteLine(" плавает.");
        }
    }
}