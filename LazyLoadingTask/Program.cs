using System;
using System.Linq;
using LazyLoadingTask.Context;

namespace LazyLoadingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new MyDbContext();
            var tmp = ctx.Categories.FirstOrDefault();
            Console.WriteLine(tmp.Products[0].Name);
        }
    }
}