using System;
using System.Collections.Generic;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var family = new Dictionary<string, Dictionary<string, string>>();

            family.Add("father", new Dictionary<string, string>() { { "name", "Al" }, { "age", "78" } });
            family.Add("mother", new Dictionary<string, string>() { { "name", "Blanche" }, { "age", "60" } });
            family.Add("sister", new Dictionary<string, string>() { { "name", "Gerri" }, { "age", "38" } });
            family.Add("brother", new Dictionary<string, string>() { { "name", "Al jr." }, { "age", "42" } });

            foreach (var (member, info) in family)
            {
                Console.WriteLine($"{info["name"]} is my {member} and they are {info["age"]} years young.");
            }
        }
    }
}
