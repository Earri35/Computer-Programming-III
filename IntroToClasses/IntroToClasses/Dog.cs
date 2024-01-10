using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    internal class Dog
    {
        //characteristics -->variables -- fields
        private String name, breed, color;
        private int age;
        private double weight;

        public Dog()
        {
            name = "";
            breed = "";
            color = "";
            age = 0;
            weight = 0.0;
        }
        public Dog(String name, String breed, String color, int age, age weight)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
            this.weight = weight;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public String toString()
        {
            return $"Name: {name} Breed: {breed} Color: {color} Age: {age} years old. Weight: {weight} lbs";
        }
    }
}
