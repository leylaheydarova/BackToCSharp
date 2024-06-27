using Practice_25;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

#region FirstSamples
List<int> numbers = new List<int>() { 2, 5, 12, 453, 123, 53, 565, 1, 2, 4, 2 };

//query expression
List<int> copyList = (from num in numbers
                      where num > 10
                      select num).ToList();

//LINQ API
List<int> copyList1 = numbers.Where(x=> x > 10).ToList();
#endregion

#region Practice Students
//List<Student> students = new()
//{
//    new()
//    {
//        Id = 1,
//        Name = "Test",
//        Grade = 89.2
//    },
//    new()
//    {
//        Id = 2,
//        Name = "Test2",
//        Grade = 99.6,
//    },
//    new()
//    {
//        Id = 3,
//        Name = "Test3",
//        Grade = 86.4
//    }
//};

//Console.WriteLine("Please, enter ID:");
//int id = Convert.ToInt32(Console.ReadLine());
//var newList = students.Where(x => x.Id == id);
#endregion

#region Counts of numbers
//List<int> numbers2 = new() { 23, 4, 8, 4, 23, 11, 6, 57, 4, 18, 8 };
//Dictionary<int, int> newList1 = new Dictionary<int, int>()
//{ };


//for (int i = 0; i < numbers2.Count; i++)
//{
//    if (newList1.ContainsKey(numbers2[i]))
//    {
//        newList1[numbers2[i]]++;
//    }
//    else
//    {
//        newList1[numbers2[i]] = 1;
//    }
//}
#endregion

#region 1)Basic Anonymous Function
//Task: Create a simple anonymous function using a lambda expression that takes an integer and returns its square.
//var res = (int value) => value * value;
//Number.ShowRes((int a) => a * a, 3);

#endregion

#region 2)Anonymous Function with Multiple Parameters
//Task: Write an anonymous function that takes two integers and returns their sum.
//Func<int,int,int>GetSum=delegate(int a, int b) { return a + b; };
#endregion

#region 3)Action Anonymous Function
//Task: Create an anonymous function using Action that takes a string and prints it to the console.
//Action<string>PrintName = (string text)=>Console.WriteLine(text);
//PrintName(Console.ReadLine());
#endregion

#region 4)Filtering with Anonymous Functions
////Task: Use an anonymous function with List<int>.Where to filter out even numbers from a list.
//Func<int, bool> isEven = (x) => x % 2 == 0;
//List<int> numbers3 = new List<int> { 26, 39, 25, 54, 3, 233, 44, 52, 31, 34, 28 };
#endregion
#region 5)Complex Filtering and Transformation
//Task: Use an anonymous function to filter a list of integers to only those that are prime, then multiply each prime number by 2.
List<int> numbers4 = new List<int> { 26, 39, 25, 54, 3, 233, 44, 52, 31, 34, 28 };
Func<int, bool> isPrime = (x) =>
{
    if (x == 1) return false;
    if (x == 2) return true;
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0) return false;
    }
    return true;
};

Func<int, int> MultiTwo = (x) => x * 2;
numbers4.Where(isPrime).Select(MultiTwo).ToList().ForEach(x => Console.WriteLine(x));
#endregion
#region 6)Chained Anonymous Functions
//Task: Create a chain of anonymous functions that first filters a list of integers to even numbers, then doubles each number, and finally sums the results.

List<int> numbers5 = new List<int>{ 2, 3, 65, 3, 4, 6, 5, 2, 1, 4, 6, 4, 2, 2, 44 };

//Func<int, int> Multifunction = (x) =>
//{
//    int res = 0;
//    for (int i = 0; i < numbers5.Count; i++)
//    {
//        if (x == 0) continue;
//        else if (x % 2 == 0)
//        {
//            res += x * 2;
//        }
//    }
//    return res;
//};

//filteration to even numbers
List<int> newList2 = new();
Func<int, List<int>> EvenFiltering = (x) =>
{
    for (int i = 0; i < numbers5.Count; i++)
    {
        if (x == 0) continue;
        else if (x % 2 == 0) newList2.Add(x); 
    }
    return newList2;
};

//double numbers
Func<int, int> DoubleNumbers = (x) =>
{
    for (int i = 0; i < newList2.Count; i++) x *= 2;
    return x;
};

//sum
Func<int, int> Sum = (x) =>
{
    int sum = 0;
    for (int i = 0; i < newList2.Count; i++)
    {
        sum += x;
    }
    return sum;
};
#endregion