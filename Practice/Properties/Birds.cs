using System;

namespace Task_3_6_7
{
    public class Birds: Animals
    {
        public Birds(string name):base(name){}
        public  void Move()
        { 
            Console.WriteLine(" летает.");
        }
    }
}