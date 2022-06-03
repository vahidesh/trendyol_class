using System;
using System.Collections.Generic;
using System.Text;

namespace trendyol_class
{
    class ManagePerson
    {
        public void PersonManager()
        {

            Person person1 = new Person();
            Console.WriteLine("Musterinin adini girin: ");
            person1.Name = Console.ReadLine();
            Console.WriteLine("Musterinin soyadini girin: ");
            person1.Surname = Console.ReadLine();
            Console.WriteLine("Musterinin ata adini girin: ");
            person1.FatherName = Console.ReadLine();
           

            Console.WriteLine("Musterinin mailini girin: ");
            person1.Email = Console.ReadLine();

            Console.WriteLine("Musterinin password girin: ");
            person1.Password = Console.ReadLine();

            string response = string.Empty;

        }
    }
}
