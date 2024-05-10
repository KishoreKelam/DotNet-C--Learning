// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.Title = "Kishore's Console App";
// Console.ForegroundColor = ConsoleColor.Green;
// // Console.WindowHeight = 40;

// Console.WriteLine("Whats your name?");
// string firstName = Console.ReadLine() ?? string.Empty;
// Console.WriteLine("Hello " + firstName);
// Console.Write("Whats your last name?");
// string lastName = Console.ReadLine() ?? string.Empty;

// Console.WriteLine("Hello " + firstName + " " + lastName);

// Console.WriteLine("Whats your age?");
// // int age = Convert.ToInt32(Console.ReadLine());
// int age = int.Parse(Console.ReadLine());

// Console.Write("Enter your num 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter your num 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter your num 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter yourfloat valie: ");
// double average = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("THe average is : " + ((num1+num2+num3)/3 + " float value: " + average + " age: " + age));
// Console.Write("Math power of 4 and 5 : " + Math.Pow(4,5));


// Random random = new Random();
// random.Next(1, 100);
// Console.ReadKey();


// using System.Runtime.InteropServices;

// System.Console.WriteLine("Ready to play the game? CLick eneter to start the game and press exit to stop the game.");
// string input = Console.ReadLine() ?? string.Empty ;
// if (input.ToLower() =="yes")
// {
//     List<string> names = new List<string>();
//     while(!names.Exists(x=> x.ToLower()=="exit")){
//         System.Console.WriteLine("Enter your name: ");
//         names.Add(System.Console.ReadLine() ?? string.Empty);
//     }

//     Console.WriteLine(names);
// }

// Console.WriteLine("Enter your string to be counted by space: ");
// string input = Console.ReadLine() ?? string.Empty;

// Console.WriteLine( "Length of words are: "+input.Split(' ').Length);
// Kishore kishore = new Kishore();
// kishore.name = "Kishore";
// kishore.age = 29;
// kishore.Num1 = 10;
// kishore.Num2 = 40;
// kishore.show();

// Kumar kumar = new Kumar();
// kumar.show();



using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

// Kumar kumar = new Kumar("Kumar", 25);


// Method1();

// void Method1()
// {
//     Console.WriteLine("This is Method1");
// }

// Method1();
// // Kelam.function1();
// Kelam kelam = new Kelam();
// kelam.function1();

// void fname(){
//     Console.WriteLine("This is function fname");
// }
// fname();

// Kelam kelam1 = new Kelam();
// kelam1.function1();

// Thread thread = new Thread(Method3);


// thread.Start();
// Method3();

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 7 };

        int maxValue = (
            from item in list
            where item > 5
            orderby item descending
            select item
        ).Count();

        IEnumerable<int> enumerable = from item in list
                                      where item > 5
                                      select item;
        Console.WriteLine("Values greater than 5 are : " + enumerable.ToList());

        Console.WriteLine("Max value is: " + maxValue);

        // List<string> listString = new List<string>() {"Kishore", "Kumar", "Kelam", "Kishore", "Kumar"};

        List<string> listString = new() { "Kishore", "Kumar", "Kelam", "Kishore", "Kumar" };

        int number1 = 100;
        string nameKishore = "Kishore"; ;

        Console.WriteLine(string.Format("{0} and {1} is right", 1000, "Kishore"));

        Console.WriteLine($"{number1} is right and {nameKishore} is right"); 

        bool success = int.TryParse("100", out int number2);



        List<string> newList = (from item in listString
                                where item == "Kishore"
                                select item).ToList();


        List<string> scoreQuery = listString.Where(x => x.StartsWith("Ki")).OrderByDescending(x => x).ToList();
        scoreQuery.ForEach(x => Console.WriteLine(x));

        // IEnumerable<string> enumerable = from item in list
        // where item > 5
        // orderby item descending
        // select $"the score is {item}";
        // foreach (string item in enumerable)
        // {
        //     Console.Write(item + " ");
        // }
        // System.Console.WriteLine("\n");

        void Method3()
        {
            display();
            Console.WriteLine("This is Method3");
        }

        void display()
        {
            Console.WriteLine("This is display method");
        }
    }
}

class Kelam
{
    public String userName = "Kishore";
    static int CountdownEvent = 0;

    public Kelam(){
        CountdownEvent++;
    }

    // Fix: Add return type 'void' to the method declaration
    public void function1(){
        Console.WriteLine("This is function: " + CountdownEvent);
    }
    

    
}

// using System.Threading;


interface ITest
{
    void show();
    void showMe(){
        Console.WriteLine("This is showMe method");
    
    }
}


class Kumar : Kishore, ITest
{
    public string name = "Kumar";
    public int age = 25;
    public Kumar()
    {
        Console.WriteLine("Name: " + this.name + " Age: " + this.age);
        Console.WriteLine(" second Name: " + name + " Age: " + age);
    }

    public Kumar(string name, int age)
    {
        this.name = name;
        this.age = age;
        // Console.WriteLine("Name: " + name + " Age: " + age);
    }

    public void show()
    {
        Console.WriteLine("Name: " + name + " Age: " + age);
    }
}

class Kishore
{
    public string name = "Kishore Kumar";
    public int age = 27;

    private int num1;
    private int num2 = 10;
    

    public int Num1
    {
        get { return num1; }
        set { num1 = value; }
    }

    //  public int Num2
    // {
    //     get { return num2; }
    //     set { num2 = value; }
    // }

    public int Num2 { get; set; }

    

    public Kishore()
    {
        Console.WriteLine("Name: " + name + " Age: " + age);
    }

    public Kishore(string name, int age)
    {
        this.name = name;
        this.age = age;
        // Console.WriteLine("Name: " + name + " Age: " + age);
    }

    public void show()
    {
        Console.WriteLine("Name: " + name + " Age: " + age + " Num1 : " + num1 + " Num2: " + num2);
    }
}