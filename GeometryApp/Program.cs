// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryLibrary;

var featureManagement = new Dictionary<string, string> 
{
    { "FeatureManagement:Square", "true"}, 
    { "FeatureManagement:Rectangle", "false"}, 
    { "FeatureManagement:Triangle", "true"}
};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

 var featureManager = serviceProvider.GetService<IFeatureManager>();

 if (await featureManager.IsEnabledAsync("Square"))
        {
            
            Console.WriteLine("Enter the value for a side of square");
            string input = Console.ReadLine()!; 
            double side = double.Parse(input);
            var square = new Square(side);
            Console.WriteLine("Area of Square: " + square.CalculateArea());
            Console.WriteLine("Perimeter of Square: " + square.CalculatePerimeter());
        }
        else
        {
            Console.WriteLine("Square feature is not valid.");
        }
if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Enter the length of rectangle");
            string x = Console.ReadLine()!; 
            double length = double.Parse(x);
            Console.WriteLine("Enter the breadth of rectangle");
            string y = Console.ReadLine()!; 
            double breadth = double.Parse(y);
            var rectangle = new Rectangle(length,breadth);
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.CalculatePerimeter());
        }
        else
        {
            Console.WriteLine("Rectangle feature is not valid.");
        }
if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Enter the base of triangle");
            string input1 = Console.ReadLine()!; 
            double b = double.Parse(input1);
            Console.WriteLine("Enter the height of triangle");
            string input2 = Console.ReadLine()!; 
            double h = double.Parse(input2);
            Console.WriteLine("Enter the side1 of triangle");
            string input3 = Console.ReadLine()!; 
            double a = double.Parse(input3);
            Console.WriteLine("Enter the side2 of triangle");
            string input4 = Console.ReadLine()!; 
            double c = double.Parse(input4);
            var triangle = new Triangle(b,h,a,c);
            Console.WriteLine("Area of Triangle: " + triangle.CalculateArea());
            Console.WriteLine("Perimeter of Triangle: " + triangle.CalculatePerimeter());
        }
        else
        {
            Console.WriteLine("Triangle feature is not valid.");
        }
