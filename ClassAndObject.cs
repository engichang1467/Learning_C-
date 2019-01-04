using System;
using System.Text;
using System.Collections.Generic;

namespace myApp
{
	// Class & Object
    class Animal
    {
    	// Properties:
    	// public - access is not limited
    	// protected - access is limited to specific class methods
    	// private - access is limited only to this specific classes methods

    	public double height{get; set;}
    	public double weight{get; set;}
    	public string sound{get; set;}

    	public string name;
    	public string Name
    	{
    		get {return name;}
    		set {name = value;}
    	}

    	// Constructor
    	public Animal()
    	{
    		this.height = 0;
    		this.weight = 0;
    		this.name = "No name";
    		this.sound = "No Sound";
    		numOfAnimals++;
		}

    	public Animal(double height, double weight, string name, string sound)
    	{
			this.height = height;
			this.weight = weight;
			this.name = name;
			this.sound = sound; 
			numOfAnimals++;
		}

    	// static field
    	static int numOfAnimals = 0;

    	public static int getNumOfAnimals()
    	{
    		return numOfAnimals;
    	} 

    	public string toString()
    	{
    		return String.Format("{0} is {1} inches tall, weights {2} lbs and like to say {3}", name, height, weight, sound);
		}

		// Method overloading - it allows us to work with different attribute type, but use the same method type
		public int getSum(int num1 = 1, int num2 = 1)
		{
			return num1 + num2;
		}

		public double getSum(double num1 = 1, double num2 = 1)
		{
			return num1 + num2;
		}




        static void Main(string[] args)
        {
        	// Create an animal object
        	/*
        	Animal spot = new Animal(15, 10, "Spot", "Woof");

        	Console.WriteLine("{0} says {1}", spot.name, spot.sound);

        	Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

        	Console.WriteLine(spot.toString());

        	Console.WriteLine(spot.getSum(num2: 1.4, num1: 2.7));

        	// another way to create a object
        	Animal grover = new Animal
        	{
        		name = "Grover",
        		height = 16, 
        		weight = 18,
        		sound = "Grrr"
        	};

        	Dog spike = new Dog();

        	Console.WriteLine(spike.toString());

        	spike = new Dog(20, 15, "Spike", "Grrr", "Chicken");

        	Console.WriteLine(spike.toString());
        	*/

        	/*
        	Shape rect = new Rectangle(5, 5);
        	Shape tri = new Triangle(5, 5);
        	
        	Console.WriteLine("Rect Area " + rect.area());
        	Console.WriteLine("Tri Area " + tri.area());

        	Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5,5);

        	Console.WriteLine("combRect Area " + combRect.area());
        	*/

        	KeyValue<string, string> superman = new KeyValue<string, string>("","");

        	superman.key = "Superman";
        	superman.value = "Clark Kent";

        	KeyValue<int, string> samsungTV = new KeyValue<int, string>(0,"");

        	samsungTV.key = 12345;
        	samsungTV.value = "A 50 inch Samsung TV";

        	superman.showData();

        	samsungTV.showData(); 	
        }
    }

    // create a subclass of Animal
    class Dog : Animal
    {
    	public string favFood {get; set; }

    	public Dog() : base()
    	{
    		this.favFood = "No Favorite Food";
    	}

    	// create a more allaborate constructor
    	public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
    	{
    		this.favFood = favFood;
    	}

    	// overwrite methods inside of Animals
    	new public string toString()
    	{
			return String.Format("{0} is {1} inches tall, weights {2} lbs and like to say {3} and eats {4}", name, height, weight, sound, favFood);
		}

    }

    // Polymorphism
    abstract class Shape
    {
    	public abstract double area();

    	public void sayHi()
    	{
    		Console.WriteLine("Hello");
    	}
    }

    // Create an interface
    public interface ShapeItem
    {
    	double area();
    }

    class Rectangle : Shape
    {
    	private double length;
    	private double width;

    	// constructor
    	public Rectangle(double num1, double num2)
    	{
    		length = num1;
    		width = num2;
    	}

    	public override double area()
    	{
    		return  length * width;
    	}

    	// operator overloading
    	public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
    	{
    		double rectLength = rect1.length + rect2.length;
    		double rectWidth = rect1.width + rect2.width;

    		return new Rectangle(rectLength, rectWidth);
    	}
    }

    class Triangle : Shape
    {
    	private double theBase;
    	private double height;

    	// constructor
    	public Triangle(double num1, double num2)
    	{
    		theBase = num1;
    		height = num2;
    	}

    	public override double area()
    	{
    		return .5 *(theBase * height);
    	}
    }

    // Generics
    class KeyValue<TKey, TValue>
    {
    	public TKey key {get; set;}
    	public TValue value {get; set;}

    	public KeyValue(TKey k, TValue v)
    	{
    		key = k;
    		value = v;
    	}

    	public void showData()
    	{
    		Console.WriteLine("{0} is {1} ", this.key, this.value);
    	}
    }
}