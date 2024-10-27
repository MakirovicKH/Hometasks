using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    internal class User
    {
        private int id;
        private string name;
        private string soyad;
        private static int age;

        public void GetFullName()
        {
            Console.WriteLine($"Full name: {name}  {soyad}");
        }

        public static void ChangeAge(int newAge)
        {
            age = newAge;
        }
    }
}
