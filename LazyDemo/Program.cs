using System;
using System.Collections.Generic;

namespace LazyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var x = DataCache.Names;
                
            }
           // Console.WriteLine("Counter Value =" + DataCache.Counter);
            Console.ReadLine();
        }
    }
    public sealed class DataCache
    {
        private static Lazy<DataCache> local = new Lazy<DataCache>(GetData);

        private List<string> _names = null;
       
        public static List<string> Names
        {
            get
            {
                return local.Value._names;
            }
        }
        private static DataCache GetData()
        {
            DataCache cache = new DataCache();
            cache._names = Employees.GetNames();
            Console.WriteLine("GetData Method Called");
            return cache;
        }

    }

    public class Employees
    {
        public static List<string> GetNames()
        {
            System.Threading.Thread.Sleep(2000);
            return new List<string>()
            {"Atul", "Ramesh", "Mahesh", "Devesh", "Ajay" };
        }
    }
}
