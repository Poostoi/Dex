using System;

namespace Task_3_6_7
{
    public abstract class Animals
    {
        
        public string Name { get; set; }
        

        public Animals()
        {
            Name = "oo";
        }
        public Animals(string name)
        {
            this.Name = name;
        }

        public void Move()
        {
            Console.Write(this.Name);
        }

    }
}