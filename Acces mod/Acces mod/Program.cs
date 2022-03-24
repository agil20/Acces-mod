using Acces_mod.Models;
using System;

namespace Acces_mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa adnizi daxil edin");
            string user=Console.ReadLine();
            Console.WriteLine("zehmet olmasa sifenizi giriniz");
            string password=Console.ReadLine();
            Console.WriteLine("zehmet olmasa yasnizi giriniz");
            int age =Convert.ToInt32(Console.ReadLine());
            User user1 = new User(user, password);
            user1.Age = age;


    }
    }
}
