using System;
using System.Collections.Generic;
using System.Text;

namespace trendyol_class
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Phones { get; set; }
        public List<string> Adress { get; set; }


    }
}
