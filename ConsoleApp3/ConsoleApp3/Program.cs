using ArraysLession2.ArraysLession2;
using System;
using System.Collections.Generic;


namespace ArraysLession2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            // int[] nums2 = new int[];


            nums.Add(15);
            nums.Add(9);
            
            foreach (var num in nums)
            {
                Console.WriteLine($"My nums is: {num}");
            }

            List<Person> persons = new List<Person>();

            Person artisPerson = new Person
            {
                Name = "Artis",
                Age = 48
            };
            persons.Add(artisPerson);
            persons.Add(artisPerson);
            persons.Add(artisPerson);

            persons.Remove(artisPerson);
            persons.RemoveAt(1);

            foreach (Person person in persons)

            {
             Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

        }
        class Programm : ProgrammBase
        {
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
            }
        }
        public class Person
        {





