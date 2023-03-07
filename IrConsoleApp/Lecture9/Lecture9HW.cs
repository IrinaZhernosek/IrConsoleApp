using IrynaZharnasek.Lecture6;

namespace IrynaZharnasek.Lecture9
{
    public class Lecture9HW
    {
        public static void List1_2()
        {
            List<int> list = new List<int>() { 10, 15, 8, 2, 5, 65, 1, 7, 32, 65 };
            int result = 0;
            foreach (int element in list)
            {
                if (element % 2 == 0)
                    result += element;
            }
            Console.WriteLine(result);
        }

        public static void List3()
        {
            List<string> list = new List<string>() { "Irina", "Lena", "Vilnius", "Anton" };
            foreach (string word in list)
            {
                if (word.Length == 5)
                    Console.WriteLine(word);
            }
        }
        public static void List4()
        {
            List<string> list = new List<string>() { "Flower", "Bird", "Sky", "Building" };
            Console.WriteLine("Please, enter the length of the searching word:");
            int count = Convert.ToInt32(Console.ReadLine());
            var selectedPeople = list.Where(p => p.Length == count);
            foreach (string person in selectedPeople)
                Console.WriteLine(person);
        }

        public static void Linked_List1()
        {
            List<string> listOfNumbers = new List<string>() { "2", "4", "3", "2", "8", "2", "5", "1", "2" };
            LinkedList<string> lnkdList = new LinkedList<string>(listOfNumbers);

            var firstEl = "2";
            var secondEl = "10";
            var currentNode = lnkdList.First;

            while (currentNode != null)
            {
                if (currentNode.Value == firstEl)
                {
                    lnkdList.AddAfter(currentNode, secondEl);
                    //if (currentNode != null)
                    currentNode = currentNode.Next;
                    Console.WriteLine(currentNode.Value);
                }
                currentNode = currentNode.Next;
                if (currentNode != null)
                    Console.WriteLine(currentNode.Value);
            }
        }

        public static void Linked_List2()
        {
            List<int> listOfNumbers1 = new List<int>() { 1, 3, 4, 7, 12 };
            List<int> listOfNumbers2 = new List<int>() { 1, 5, 7, 9 };
            List<int> listOfNumbers3 = new List<int>() { };
            LinkedList<int> lnkList1 = new LinkedList<int>(listOfNumbers1);
            LinkedList<int> lnkList2 = new LinkedList<int>(listOfNumbers2);
            var currentNode = lnkList1.First;
            while (currentNode != null)
            {
                if (lnkList2.Contains(currentNode.Value))
                {
                    listOfNumbers3.Add(currentNode.Value);
                    currentNode = currentNode.Next;
                }
                currentNode = currentNode.Next;
            }
            foreach (int i in listOfNumbers3)
            {
                Console.WriteLine(i);
            }
        }
        public static void QueueAndStack1()
        {
            List<int> listOfNumbers = new List<int>() { 1, 4, 72, 12 };
            Queue<int> newNumbers = new Queue<int>(listOfNumbers);
            Console.WriteLine("Please, enter the first value for queue:");
            newNumbers.Enqueue(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Please, enter the second value for queue:");
            newNumbers.Enqueue(Convert.ToInt32(Console.ReadLine()));
            foreach (int i in newNumbers)
            {
                Console.WriteLine($"The queue contains next elements: {i}");
            }
            Console.WriteLine($"Max value from Queue is {newNumbers.Max()}");
        }
        public static void QueueAndStack2()
        {
            Stack<string> stackOfLetters = new Stack<string>();
            Console.WriteLine("Please, enter the first letter for stack:");
            stackOfLetters.Push(Console.ReadLine());
            Console.WriteLine("Please, enter the second letter for stack:");
            stackOfLetters.Push(Console.ReadLine());
            Console.WriteLine("Please, enter the third letter for stack:");
            stackOfLetters.Push(Console.ReadLine());
            while (stackOfLetters.Count > 0)
            {
                var letters = stackOfLetters.Pop();
                Console.WriteLine(letters);
            }
        }
        public static void Dictionary1()
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1.Add("Ira", 33);
            dict1["Lena"] = 28;
            Console.WriteLine($"The first element added to collection: {dict1.First()}");
            foreach (var item in dict1)
            {
                Console.WriteLine($"\nCollection includs Key: {item.Key}, Value: {item.Value}");
            }
        }
        public static void Dictionary2()
        {
            List<int> listOfNumbers = new List<int>() { 1, 8, 5, 3, 9, 2, 4, 7, 6, 0 };
            List<string> listOfNames = new List<string>() { "Ira", "Anton", "Vova", "Lena", "Alisa", "Ilya", "Kira", "Nadya", "Anya", "Tim" };
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            listOfNumbers.Sort();
            listOfNames.Sort();
            listOfNames.Reverse();
            Dictionary<List<int>, List<string>> dict = new Dictionary<List<int>, List<string>>();
            dict.Add(listOfNumbers, listOfNames);
            foreach (var item in dict)
            {
                for (var i = 0; i < 10; i++)
                    Console.WriteLine($"Key: {item.Key[i]}, Value: {item.Value[i]}");
            }

            foreach (var item in listOfNumbers)
            {
                Console.WriteLine(item);
            }
            foreach (var item in listOfNames)
            {
                Console.WriteLine(item);
            }
        }
        public static void Dictionary3()
        {
            Dictionary<string, City> dict = new Dictionary<string, City>();
            dict.Add("Vilnius", new City { population = 544386, area = 320.8 });
            dict.Add("Minsk", new City { population = 2000000, area = 348.0 });
            dict.Add("Vitebsk", new City { population = 362466, area = 124.5 });
            dict.Add("Klaipeda", new City { population = 152818, area = 98.0 });
            dict.Add("Brest", new City { population = 139163, area = 49.51 });
            Console.WriteLine("**************** Subtask a ****************");
            var sorted = from d in dict orderby d.Value.area ascending select d;
            foreach (var i in sorted)
            {
                Console.WriteLine($"The city {i.Key} is placed on area      {i.Value.area}");
            }
            var pop = from d in dict orderby d.Value.population descending select d;
            Console.WriteLine("**************** Subtask b ****************");
            foreach (var i in pop)
            {
                Console.WriteLine($"The city {i.Key} is placed on area      {i.Value.population}");
            }
            Console.WriteLine("**************** Subtask c ****************");
            var sumPop = dict.Sum(x => x.Value.population);
            Console.WriteLine($"The total number of people in all cities: {sumPop}");
        }
    }
}
