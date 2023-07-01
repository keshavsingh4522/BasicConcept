// See https://aka.ms/new-console-template for more information
using InterviewQuestions;

Console.WriteLine("Hello, World!");
var a = "2001";
var b = 2001;

/* 1.
a = b;
*/

/* 2.
if (a == b)
{
}
*/

// 3
// B b2 = new A();   -> bigger can not hold small. small can hold big
A a2 = new B();
B b2 = new B();
Console.WriteLine("a2.Add(5, 6): {0}", a2.Add(5, 6));
Console.WriteLine("b2.Add(5, 6): {0}", b2.Add(5, 6));

// 4
int[] nums = { 1, -2, 3, 0, -4, 5 };
// Below is incorrect
//int filterdNums = from n in nums
//                  where n > -5 && n<6
//                  orderby n descending
//                  select n;
var items = from n in nums
                  where n > -5 && n < 6
                  orderby n descending
                  select n;
foreach (var item in items)
    Console.WriteLine(item);

// 5
string[] grades = { "Grade 1", "Grade 3", "Grade 4", "Grade 2" };
IEnumerable<string> gradeQuery = from n in grades
            orderby n
            select n;
foreach (var item in gradeQuery)
    Console.WriteLine(item);