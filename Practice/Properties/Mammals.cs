using System;

namespace Task_3_6_7
{
    public class Mammals: Animals
    {
        public Mammals(string name):base(name){}
        private  void  Move()
        {
            base.Move();
            Console.WriteLine(" бегает.");
        }
    }
}