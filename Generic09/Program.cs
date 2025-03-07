using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic09 // push to GitHub
{
    class GenericDictionaryExample
    {
        public static void Main()
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {1, "John" },
                {2, "Emma" }, // only accept specific Data type integer and String
                {3, "Luke" },
                {4, "Sam" }
            };

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }
}
