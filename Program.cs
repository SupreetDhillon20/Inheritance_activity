using System.ComponentModel.DataAnnotations;

namespace activity2
{
    //Part 1: Creating abstract Animal Class
    public abstract class Animal
    {
        //Properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int age { get; set; }

        //Abstract method
        public abstract void Eat();
    }

    //Dog class implements the Animal class and Eat method
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }

    //Cat class implements the Animal class and Eat method
    public class Cat : Animal
    {
        public override void Eat() 
        {
            Console.WriteLine("Cats eat mice.");
        }
    }

    //partial 2: Interface IAnimal
    interface IAnimal
    {
        //Properties
        string Name { get; set; }
        string Colour { get; set; }
        int age { get; set; }
        double Height { get; set; }

        //Methods
        void Eat();
        string Cry();
    }

    //Dog class implements IAnimal
    class Dog2 : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int age { get; set; }
        public double Height { get; set; }

        //Implementing Eat and Cry method
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }

    //Cat class implements IAnimal
    class Cat2 : IAnimal
    {
        //Properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int age { get; set; }
        public double Height { get; set; }

        //Implementing Eat and Cry method
        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
        public string Cry()
        {
            return "Meow!";
        }
    }

    class Mainclass 
    {
        static void Main()
        {
            //Part 1
            //Taking inputs from user for Dog
            Dog dog = new Dog();

            Console.Write("Name of the dog: ");
            dog.Name = Console.ReadLine();

            Console.Write("Colour of the dog: ");
            dog.Colour = Console.ReadLine();

            Console.Write("Age of the dog: ");
            dog.age = Convert.ToInt32(Console.ReadLine());

            //Display properties and call Eat method
            Console.WriteLine($"\nName of dog is {dog.Name}");
            Console.WriteLine($"Colour of dog is {dog.Colour}");
            Console.WriteLine($"Age of dog is {dog.age} years");
            dog.Eat();

            //Taking inputs from user for Cat
            Cat cat = new Cat();

            Console.Write("\nName of Cat: ");
            cat.Name = Console.ReadLine();

            Console.Write("Colour of Cat: ");
            cat.Colour = Console.ReadLine();

            Console.Write("Age of Cat: ");
            cat.age = Convert.ToInt32(Console.ReadLine());

            //Display properties and call Eat method
            Console.WriteLine($"\nName of the cat is {cat.Name}");
            Console.WriteLine($"Colour of cat is {cat.Colour}");
            Console.WriteLine($"Age of cat is {cat.age} years");
            cat.Eat();

            //Part 2 
            //Taking inputs for Dog2
            Dog2 dogI = new Dog2();

            Console.Write("\nName of Dog: ");
            dogI.Name = Console.ReadLine();

            Console.Write("Colour of Dog: ");
            dogI.Colour = Console.ReadLine();

            Console.Write("Height of Dog (in cms): ");
            dogI.Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Age of Dog: ");
            dogI.age = Convert.ToInt32(Console.ReadLine());

            //Display properties and call Eat and Cry methods
            Console.WriteLine($"\nName of Dog is {dogI.Name}");
            Console.WriteLine($"Colour of Dog is {dogI.Colour}");
            Console.WriteLine($"Height of Dog is {dogI.Height} cms");
            Console.WriteLine($"Age of Dog is {dogI.age} years");

            dogI.Eat();
            Console.WriteLine($"Dog says: {dogI.Cry()}");

            //Taking input for Cat2
            Cat2 catI = new Cat2();

            Console.Write("\nEnter cat's name: ");
            catI.Name = Console.ReadLine();

            Console.Write("Enter cat's colour: ");
            catI.Colour = Console.ReadLine();

            Console.Write("Enter cat's height (in cms): ");
            catI.Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter cat's age: ");
            catI.age = Convert.ToInt32(Console.ReadLine());

            // Print properties and call methods
            Console.WriteLine($"\nName of Cat is {catI.Name}");
            Console.WriteLine($"Colour of Cat is {catI.Colour}");
            Console.WriteLine($"Height of Cat is {catI.Height} cms");
            Console.WriteLine($"Age of Cat is {catI.age} years");

            catI.Eat();
            Console.WriteLine($"Cat says: {catI.Cry()}");

            // Create a list of animals
            List<IAnimal> animals = new List<IAnimal> {dogI,catI};

            // Print the names of all animals in the list
            Console.WriteLine("\nNames of all animals in the list:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
