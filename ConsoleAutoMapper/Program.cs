using ConsoleAutoMapper.Types;
using System;

namespace ConsoleAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Nazım",
                Surname = "Demir",
                MailAdress = "nazim.demir@yahoo.com"
            };

            dtoPerson _dtoPerson = new dtoPerson();
            _dtoPerson = person.ObjectMap<Person, dtoPerson>(_dtoPerson);

            Console.WriteLine(string.Format("{0} {1}", _dtoPerson.Name, _dtoPerson.Surname));
            Console.ReadLine();
        }
    }
}