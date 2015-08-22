namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    class Animals
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Rex", GEnder.Male, 3, "Pomiqr"),
                new Dog("Jorko", GEnder.Male, 1, "Poodle"),
                new Dog("Pepa", GEnder.Female, 5, "German Shepherd"),
                new Dog("Pesho", GEnder.Male, 2, "Pekingese"),

                new Frog("Jabko", GEnder.Male, 1),
                new Frog("Kikerica", GEnder.Female, 3),
                
                new Cat("Maca", GEnder.Female, 5, "Ulichna Prevyzhodna"), 
                new Tomcat("Tom", 5), 
                new Tomcat("Gosho", 3),
                new Kitten("Puhcho", 1, "Sphynx"), 
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);

            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);
        }
    }
}
