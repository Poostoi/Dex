using System;
using System.Dynamic;

namespace Practice.HomeWorkIQueryable
{
    public class GenerateItem
    {
        private Item[] ArrayItem = new Item[100];

        public void Generate(string[] name)
        {
            Random random = new Random();
            for (int i = 0; i < ArrayItem.Length; i++)
            {
                ArrayItem[i] = new Item(name[random.Next(0, name.Length)], random.Next(0, 500),
                    new DateTime(random.Next(1583, 2021), random.Next(1, 12), random.Next(1, 28)),
                    Convert.ToBoolean(random.Next(0, 1)));
            }
        }

        public void ConsoleOutput(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Name: {0},\nDate: {1},\nAmount:{2},\nExist: {3}.",ArrayItem[i].Name,
                    ArrayItem[i].Date,ArrayItem[i].Number,ArrayItem[i].Exist);
            }
        }


    }
}