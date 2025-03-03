// See https://aka.ms/new-console-template for more information
using System.Reflection;

//Get the Assembly Reference
var MyAssembly = Assembly.Load(@"..\SampleClassLibrary.dll");

//Get the Class Reference
var MyType = MyAssembly.GetType("SampleClassLibrary.SampleClass");

//Create an instance of the type
dynamic MyObject = Activator.CreateInstance(MyType);

//Get the Type of the Instance
Type parameterType = MyObject.GetType();

//Step3: Browse the Metadata
//To Get all Public Fields/variables
Console.WriteLine("All Public Fields");
foreach (MemberInfo memberInfo in parameterType.GetFields())
{
    Console.WriteLine(memberInfo.Name);
}

//To Get all Public Methods
Console.WriteLine("\nAll Public Methods");
foreach (MemberInfo memberInfo in parameterType.GetMethods())
{
    Console.WriteLine(memberInfo.Name);
}

//To Get all Public Properties
Console.WriteLine("\nAll Public Properties");
foreach (MemberInfo memberInfo in parameterType.GetProperties())
{
    Console.WriteLine(memberInfo.Name);
}
Console.ReadKey();


