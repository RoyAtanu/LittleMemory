using System;
using LittleMemory.DataType;

namespace LittleMemory.DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LMList<string> _list = new LMList<string>();
            _list.Add("a_new_string");

            Console.WriteLine(_list.Count);
        }
    }
}
