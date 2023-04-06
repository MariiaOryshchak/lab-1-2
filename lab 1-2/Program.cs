using Newtonsoft.Json;

namespace Laba1_sem_2
{


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Task1 task1 = new Task1();
            Console.WriteLine("Task 2:");
            Task2 task2 = new Task2();
            Console.WriteLine("Task 3:");
            Task3 task3 = new Task3();
        }


    }
    public class Task1
    {
        public Task1()
        {
            Dictionary<int, string> WordsInDictionary = new Dictionary<int, string>();

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            string[] arrayOfWordsFromText = text.Split(' ');

            int index = 0;

            while (index < arrayOfWordsFromText.Length)
            {
                WordsInDictionary.Add(index, arrayOfWordsFromText[index]);
                index++;
            }


            Console.WriteLine($"\nNumber of words in text = {arrayOfWordsFromText.Length}\n");

            foreach (KeyValuePair<int, string> i in WordsInDictionary)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            Console.Write("\nEnter element: ");
            int element = int.Parse(Console.ReadLine());

            string direction;

            do
            {
                Console.Write("\nEnter direction (back/forward): ");
                direction = Console.ReadLine();

                if (direction == "forward")
                {
                    for (index = element; index < arrayOfWordsFromText.Length; index++)
                    {
                        Console.WriteLine(arrayOfWordsFromText[index]);
                    }
                    break;
                }

                if (direction == "back")
                {
                    for (index = element; index >= 0; index--)
                    {
                        Console.WriteLine(arrayOfWordsFromText[index]);
                    }
                    break;
                }
            } while (direction != "forward" || direction != "back");

            Console.ReadLine();

        }
    }
    public class Task2
    {
        public Task2()
        {


            Dictionary<string, string> people = new Dictionary<string, string>();
            Random random = new Random();
            string[] names = { "Anna", "Bill", "Alex", "Mary", "Donald" };
            string[] cities = { "New York", "Los Angeles", "Las Vegas", "Washington", "San Francisco" };

            for (int i = 0; i < 5; i++)
            {
                people.Add(names[i], cities[random.Next(5)]);
            }

            Console.WriteLine("List before:");
            foreach (KeyValuePair<string, string> i in people)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }

            var sortedKeys = from i in people.Keys
                             orderby i
                             select i;

            Console.WriteLine("\nList after (only keys):");
            foreach (var key in sortedKeys)
            {
                Console.WriteLine(key);
            }

            string json = JsonConvert.SerializeObject(people);
            Console.WriteLine("\nJSON: " + json);

            Console.ReadLine();
        }
    }
    public class Task3
    {
        public Task3()
        {

            List<int> list = new List<int>();
            Random random = new Random();
            int elements = 15;

            Console.WriteLine("\nList of numbers:\t ");
            for (int i = 0; i < elements; i++)
            {
                list.Add(random.Next(-99, 100));
                Console.Write(list[i] + "\t");
            }

            Console.WriteLine("\nList of numbers after sorting: ");
            var newlist = from i in list
                          where i > 10 && i < 100
                          orderby i
                          select i;

            foreach (var item in newlist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}

