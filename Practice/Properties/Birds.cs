using System;

namespace Task_3_6_7
{
    public class Birds: Animals
    {
        public Birds(string name):base(name){}
        public  void Move()
        {   
            //предлагаю написать так:
            base.Move();
            Console.WriteLine(" летает."); //при выводе будет просто слово "летает". Базовая реализация в данном случае не сработает.
            
        }
    }
}
