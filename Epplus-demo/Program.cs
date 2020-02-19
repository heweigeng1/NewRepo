using System;

namespace Epplus_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            EpplusSaveHelper.SaveToExcel<Orders>(TestDataModels.GetData(), @$"C:\Users\何伟庚\Desktop\女总统_6LargeIndustrialData{new Random().Next(1,199999)}.xlsx");
            Console.WriteLine("Hello World!");
        }
    }
}
