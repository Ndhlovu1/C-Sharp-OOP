using System;

public class Program
{


public class Animal
{

    public virtual void makeSound ()
    {
        Console.WriteLine("Animal makes a sound");
    }

    public interface IAnimal
    {
        public void Eat();
    }

    
}


public class Dog : Animal
{

    public override void makeSound()
    {
        Console.WriteLine("Barking");
    }

    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
    

}


public class Cat : Animal
{

    public override void makeSound()
    {
        Console.WriteLine("Meowing");
    }

    public void Eat()
    {
        Console.WriteLine("Cat is eating");
    }
    
}






public static void Main(string[] args)
    {
        Console.WriteLine("Calling Dog to Eat");
        Dog dog = new Dog();
        dog.Eat();
        
    }


    
}



