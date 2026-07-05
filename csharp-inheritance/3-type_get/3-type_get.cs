using System;
using System.Reflection;

/// <summary>
/// Provides helper methods for inspecting objects using reflection.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of all public properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine("{0} Properties:", type.Name);
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", type.Name);
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}