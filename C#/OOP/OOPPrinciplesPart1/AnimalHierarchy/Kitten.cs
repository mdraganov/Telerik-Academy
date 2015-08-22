﻿namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, string breed)
            : base(name, age, breed)
        {
            this.Gender = GEnder.Female;
        }
    }
}