using System;
public class Octopus
{
//Properties
    public string Name {get; set;}
    public string Color {get; set;}
    public int Arms {get; set;}
    public int Age {get; set;}

    //Constructor
    public Octopus(string name, string color, int arms, int age)
    {
        Name = name;
        Color = color;
        Arms = arms;
        Age = age;
    }
    //Method
    public void Print()
    {
        Console.WriteLine($"Good day, my name is {Name}, I am a {Age} year old {Color} Octopus with {Arms} arms.");
    }
    
    }
    class Program
    {
        static void Main()
        {
           //Instance of Class Octopus
           Octopus oct1 = new Octopus("Ralphy", "Red", 33, 956);
           oct1.Print(); 
        }
        
    }