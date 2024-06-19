

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods;
public static class MyFirstExtensionMethods {

    public static void Debug(this string str, string label) {
        Console.WriteLine($"{label}: [{str}]");
    }

    public static void Debug(this int i, string label) {
        Console.WriteLine($"{label}: [{i}]");
    }

    public static int Cubed(this int i) {
        return i * i * i;
    }

    public static int Func(this int x) {
        return (x * x) + (x * 3) + 5;
    }

    public static void Debug(this Customer customer, string header) {
        Console.WriteLine($"***** {header} *****");
        Console.WriteLine($"Id:         {customer.Id}");
        Console.WriteLine($"Name:       {customer.Name}");
        Console.WriteLine($"City:       {customer.City}");
        Console.WriteLine($"StateCode:  {customer.StateCode}");
        Console.WriteLine($"Sales:      {customer.Sales:C}");
    }
}
