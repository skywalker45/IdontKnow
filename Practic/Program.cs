using Newtonsoft.Json;
using System;
using System.IO;

namespace Practic
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RootObject root = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(@"C:\Users\Daniel Salami\source\repos\Practic\Practic\Quiz.json"));
            Quiz quiz = root?.Quiz;

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"C:\Users\Daniel Salami\source\repos\Practic\Practic\Quiz.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                RootObject root2 = (RootObject)serializer.Deserialize(file, typeof(RootObject));

                Console.WriteLine($"Maths q1: {root2.Quiz.maths.q1.answer}, {root2.Quiz.maths.q1.question}," +
                    $" {string.Join(",", root2.Quiz.maths.q1.options)}");

                Console.WriteLine($"Maths q2: {root2.Quiz.maths.q2.answer}, {root2.Quiz.maths.q2.question}," +
                    $" {string.Join(",", root2.Quiz.maths.q2.options)}");

                Console.WriteLine($"sport: {root2.Quiz.sport.q1.answer}, {root2.Quiz.sport.q1.question}," +
                    $" {string.Join(",", root2.Quiz.sport.q1.options)}");
            }
        }
    }
}
