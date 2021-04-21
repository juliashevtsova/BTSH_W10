using System;
using System.Collections.Generic;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> _person = new List<string>();

            _person.Add("dance");
            Person tom;
            tom.name = "TOm";
            tom.age = 23;
            tom._hobbies = _person;
            tom._hobbies.Add("music");
            tom.DisplayInfo();
            ChangePerson(tom, _person);

        }

        public static void ChangePerson(Person tom, List<string> _person)
        {
            tom.name = "Jared";
            tom.age = 26;
            tom._hobbies = _person;
            tom._hobbies.Remove("music");
            tom._hobbies.Add("drink");
            Console.WriteLine();
            tom.DisplayInfo();
        }
    }

    public struct Person
    {
        public int age;

        public string name;

        public List<string> _hobbies;
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
            Console.WriteLine("Hobbies:");

            foreach (string str in _hobbies)
            {
                Console.Write(str + "  ");
            }
        }
    }    
}
