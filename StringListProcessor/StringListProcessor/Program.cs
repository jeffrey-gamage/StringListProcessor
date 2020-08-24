using System;
using System.Collections.Generic;

namespace StringListProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initial = new List<string>{ "one", "two", "three" };
            List<string> to_add = new List<string> { "one", "two", "five","six" };
            List<string> to_remove = new List<string> {"two", "five"};
            List<string> result = ProcessStringLists(initial, to_add, to_remove);
            foreach(string nextString in result)
            {
                Console.WriteLine(nextString);
            }
            Console.ReadLine();
        }

        static List<string> ProcessStringLists(List<string> initial, List<string> to_add, List<string> to_remove)
        {
            SortedSet<UrtheCastOrderedString> orderedStrings = new SortedSet<UrtheCastOrderedString>();
            foreach(string nextString in initial)
            {
                orderedStrings.Add(new UrtheCastOrderedString(nextString));
            }
            foreach (string nextString in to_add)
            {
                orderedStrings.Add(new UrtheCastOrderedString(nextString));
            }
            List<string> result = new List<string>();
            foreach(UrtheCastOrderedString orderedString in orderedStrings)
            {
                result.Add(orderedString._string);
            }
            foreach(string nextToRemove in to_remove)
            {
                result.Remove(nextToRemove);
            }
            return result;
        }
    }
}
