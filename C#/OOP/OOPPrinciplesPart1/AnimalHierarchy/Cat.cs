﻿namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, GEnder gender, int age, string breed)
            : base(name, gender, age)
        {
            this.Breed = breed;
        }

        public Cat(string name, int age, string breed)
            : base(name, age)
        {
            this.Breed = breed;
        }

        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public string Breed { get; private set; }

        public override void MakeSound()
        {
            Console.WriteLine("{0} says Meow, meow", this.Name);
        }
    }
}