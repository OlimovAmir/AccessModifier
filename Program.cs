using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        AccessModifier.Point point = new AccessModifier.Point();

        //point.PrintY();

        // Получить все открытые и неоткрытые (public и private) поля класса Point
        var fields = typeof(AccessModifier.Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var field in fields)
        {
            Console.WriteLine($"Field Name: {field.Name}, Type: {field.FieldType}, isPublic: {field.IsPublic}");
        }
    }
}