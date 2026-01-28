// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//class

//class Car
//{
//    string color = "red";

//    static void Main(string[] args)
//    {
//        Car c1 = new Car();
//        Console.WriteLine(c1.color);
//    }
//}


//class Members
//class Car
//{
//    string color = "red";
//    int maxSpeed = 200;

//    static void Main(string[] args)
//    {
//        Car myObj = new Car();
//        Console.WriteLine(myObj.color);
//        Console.WriteLine(myObj.maxSpeed);
//    }
//}

//constructor
// Create a Car class
//class Car
//{
//    public string model;  // Create a field

//    // Create a class constructor for the Car class
//    public Car()
//    {
//        model = "Mustang"; // Set the initial value for model
//        model = "Audi";
//    }

//    static void Main(string[] args)
//    {
//        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
//        Console.WriteLine(Ford.model);  // Print the value of model
//    }
//}

// Outputs "Mustang"

//GET SET METHODS

//class Person
//{
//    private string name; // field
//    public string Name   // property
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person myObj = new Person();
//        myObj.Name =Console.ReadLine();
//        Console.WriteLine(myObj.Name);
//    }
//}


//inheritance
class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Program
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}