# InterviewPreparation

<details>
<summary>Interface And Abstraction</summary>

Interface | Abstraction 
------ | ----- 
| **Interface** keyword is used.  | **abstract** keyword is used to define abstract class. |
| Interface is not a class | Abstract is a class. |
| Interface are implemented | Abstract class are inherited. |
| A class can inherit from more than one interface. ex. ```public class AV : IAV1, IAV2, IAV3{} ``` | A class can extend only one abstract class. |
| Allow multiple inheritance.| Abstract classes do not allow multiple inheritance |
| In interfaces, the body is definitely not found. The body is created in the inherited subclass. | Methods in abstract classes can have bodies or are marked abstract and override in the inheriting class. |
| Does not contain the constructor and static members. | Can contain the constructor and static members. |
| All elements in Interface must be implemented in subclass. | In abstract classes, only abstract elements must be overridden in subclasses. Unsigned members do not have to be in subclasses. In this way, code clutter is avoided by keeping only the common features in the subclasses. |
| An interface can not have access modifier, by default all is public. and we define these in implemented class. | All access modifier is accepted.  |

</details>

<details>
<summary>Filters</summary>
 
 - Authorization FIlter
 - Resource Filter
 - Action Filter
 - Result Filter
 - Exception Filter

### A filter can be added to the pipeline at one of three scopes: 
- by action method, 
- by controller class or 
- globally (which be applied to all the controller and actions). 
> We need to register filters in to the MvcOption.Filters collection within ConfigureServices method.

![](https://camo.githubusercontent.com/4711bb74ccf3f761f71bec058afa51a2d7c5aae62b3a7d2ea384b36a04349955/68747470733a2f2f66346e33783663352e737461636b7061746863646e2e636f6d2f61727469636c652f776f726b696e672d776974682d66696c746572732d696e2d6173702d6e65742d636f72652d6d76632f496d616765732f312e706e67)

![](https://camo.githubusercontent.com/cc25260ca6c4b609ad9403e297a7a304b0395e03e3d3e4ca3726f0fc95f8fe17/68747470733a2f2f66346e33783663352e737461636b7061746863646e2e636f6d2f61727469636c652f776f726b696e672d776974682d66696c746572732d696e2d6173702d6e65742d636f72652d6d76632f496d616765732f322e706e67)

### We can apply our filter to the controller class or action method using one of the following, 
- ServiceFilterAttribute
```c#
[ServiceFilter(typeof(ExampleFilterWithDI))]  
public IActionResult Index()  
{  
    return View();  
}
```
- TypeFilterAttribute
    - It is very similar to ServiceFilterAttribute and also implemented from IFilterFactory interface.
    - The "TypeFilterAttribute" can be optionally accept constructor arguments for the type. 
```c#
[TypeFilter(typeof(ExampleFilterAttribute), Arguments = new object[] {"Argument if any" })]  
public IActionResult About()  
{  
    return View();  
}
```
- IFilterFactory implemented on attribute


References: <br>

- [https://www.c-sharpcorner.com/article/working-with-filters-in-asp-net-core-mvc](https://www.c-sharpcorner.com/article/working-with-filters-in-asp-net-core-mvc/)

</details>

<details>
<summary>Ref and Out</summary>

- ref tells the compiler that the object is initialized before entering the function, while out tells the compiler that the object will be initialized inside the function.

- So while ref is two-ways, out is out-only.


| Ref | Out |
| --- | --- |
| The parameter or argument must be initialized first before it is passed to ref. |	It is not compulsory to initialize a parameter or argument before it is passed to an out. |
| It is not required to assign or initialize the value of a parameter (which is passed by ref) before returning to the calling method. | 	A called method is required to assign or initialize a value of a parameter (which is passed to an out) before returning to the calling method. |
| Passing a parameter value by Ref is useful when the called method is also needed to modify the pass parameter. |	Declaring a parameter to an out method is useful when multiple values need to be returned from a function or method. |
| It is not compulsory to initialize a parameter value before using it in a calling method. |	A parameter value must be initialized within the calling method before its use. |
| When we use REF, data can be passed bi-directionally. | When we use OUT data is passed only in a unidirectional way (from the called method to the caller method). |
| Both ref and out are treated differently at run time and they are treated the same at compile time. |

References:
- [https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/](https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/)

</details>

<details>
<summary> Polymorphism </summary>

- Polymorphism means "one name many forms"
- In other words, one object has many forms or has one name with multiple functionalities.

### Types of Polymorphism

_There are two types of polymorphism in C#:_
- Static / Compile Time Polymorphism / Early binding
    - Overloading is the concept in which method names are the same with different parameters. 
    - The method/function has the same name but different signatures in overloading.
```c#
public class TestData
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
}
```
- Dynamic / Runtime Polymorphism / late binding
    - When overriding a method, you change the behavior of the method for the derived class.


![](https://camo.githubusercontent.com/40913eb9b10c9753e24d704451994e1b0887620b59c525eabc7c90639a84c867/68747470733a2f2f66346e33783663352e737461636b7061746863646e2e636f6d2f55706c6f616446696c652f6666326630382f756e6465727374616e64696e672d706f6c796d6f72706869736d2d696e2d432d53686172702f496d616765732f706c6f796d6f72706869736d2e6a7067)


### Other points about polymorphism:

    Method Overriding differs from shadowing.
    Using the "new" keyword, we can hide the base class member."
    We can prevent a derived class from overriding virtual members.
    We can access a base class virtual member from the derived class

***In C#, by default, all the members of a class are sealed and cannot be redefined in the derived class. Use the virtual keyword with a member of the base class to make it overridable, and use the override keyword in the derived class to indicate that this member of the base class is being redefined in the derived class***

### Rules for Overriding:

    A method, property, indexer, or event can be overridden in the derived class.
    Static methods cannot be overridden.
    Must use virtual keyword in the base class methods to indicate that the methods can be overridden.
    Must use the override keyword in the derived class to override the base class method.


References:
- [https://www.c-sharpcorner.com/UploadFile/ff2f08/understanding-polymorphism-in-C-Sharp/](https://www.c-sharpcorner.com/UploadFile/ff2f08/understanding-polymorphism-in-C-Sharp/)
- [https://www.tutorialsteacher.com/csharp/method-overriding](https://www.tutorialsteacher.com/csharp/method-overriding)
</details>

<details>
<summary>Boxing and Unboxing</summary>

- Boxing
    - The conversion of value type to reference type is known as boxing.
![](https://camo.githubusercontent.com/c9821116564e899b1028d1a2877dd3247c1d98abf5c497b79c61a8f939958f42/68747470733a2f2f7777772e7475746f7269616c73746561636865722e636f6d2f436f6e74656e742f696d616765732f61727469636c65732f6373686172702f626f78696e672e504e47)

- Unboxing
    - The conversion of reference type to value is known as unboxing.
![](https://camo.githubusercontent.com/cfe6e987e2db984639001d98acc69faeda0a4d8626d8abdf3dd54f4fdaad6cc1/68747470733a2f2f7777772e7475746f7269616c73746561636865722e636f6d2f436f6e74656e742f696d616765732f61727469636c65732f6373686172702f756e626f78696e672e504e47)

References:
- [https://www.tutorialsteacher.com/articles/boxing-unboxing-in-csharp](https://www.tutorialsteacher.com/articles/boxing-unboxing-in-csharp)

</details>

<details>
<summary>DI</summary>

- It is a design pattern that allows objects to depend on other objects, called dependencies, without creating them directly.
- It is a software design pattern which enables the development of loosely coupled code. Through DI, you can decrease tight coupling between software components. It is also known as Inversion-of-Control.

### There are three types of DIs:
    Constructor Injection
    Setter Injection
    Method Injection

### There are 3 types of lifetimes supported by ASP.NET Core for the dependency injection,
- Transient Service
    - New instance transient service is created whenever the service is requested.
- Scoped Service
    - Created once per scope; i.e., web request.or any unit of work.
- Singleton Service
    - Singleton service is only created when it is called for the first time. In the next subsequent requests, the same instance is provided. 

---
References
- [https://stackify.com/dependency-injection-c-sharp/](https://stackify.com/dependency-injection-c-sharp/)

</details>

<details>
<summary>What are the features of C#?</summary>

1. Object-Oriented Programming
```
C# is an object-oriented programming (OOP) language. It supports features such as classes, objects, encapsulation, inheritance, and polymorphism.
```

2. Type Safety
```
It is a type-safe language, which means that it enforces type checking at compile time to ensure that variables are used only in the ways intended by the programmer. Example:-
```
```C#
int x = 10;   // declaring an integer variable and initializing it with value 10
string str = "Hello, World!";   // declaring a string variable and initializing it with a string value

// We cannot assign a string value to an integer variable:
x = str;   // This will result in a compilation error

// Similarly, we cannot call a method on a variable that doesn't support it:
int y = 5;
y.ToUpper();   // This will result in a compilation error since ToUpper() method 
```

3. Garbage Collection
```
C# includes automatic garbage collection, which automatically frees up memory that is no longer being used by the program.
```

4. Cross-Platform Support
``` 
C# can be used to develop applications for a wide range of platforms, including Windows, macOS, Linux, and mobile devices.
```

5. Language Interoperability 
```
C# can interoperate with other programming languages, including C, C++, and Visual Basic.
```

6. LINQ
```
Language Integrated Query (LINQ) is a powerful feature in C# that allows developers to query and manipulate data from different data sources using a uniform syntax.
```

7. Asynchronous Programming
```
C# includes support for asynchronous programming, which allows developers to write code that can execute concurrently without blocking the main thread.
```

<details>
<summary>What is Asynchronous and synchronous with example in c#</summary>

- Synchronous refers to an operation that blocks the execution of the program until the operation completes

- Asynchronous, on the other hand, refers to an operation that does not block the execution of the program but instead executes in the background, allowing the program to continue executing other operations.

### Here's an example of synchronous code in C#:
```c#
public static void Main()
{
    Console.WriteLine("Starting synchronous operation...");
    string result = GetDataFromWeb(); // This method blocks the execution until it gets the data
    Console.WriteLine("Synchronous operation completed with result: " + result);
}

public static string GetDataFromWeb()
{
    // This method makes a web request to get some data
    WebClient client = new WebClient();
    string result = client.DownloadString("http://example.com");
    return result;
}

```
> In the above code, the `Main` method makes a call to the `GetDataFromWeb` method, which makes a web request to retrieve some data. Since this operation is synchronous, the execution of the program is blocked until the web request completes and returns the data. Only then does the program continue to execute the next line of code.

### Here's an example of asynchronous code in C#:
```c#
public static async Task Main()
{
    Console.WriteLine("Starting asynchronous operation...");
    Task<string> resultTask = GetDataFromWebAsync(); // This method executes in the background
    Console.WriteLine("Asynchronous operation started, program continues executing other operations...");

    // Do some other work here while the GetDataFromWebAsync() method is executing in the background

    string result = await resultTask; // This line blocks until the GetDataFromWebAsync() method completes and returns the data
    Console.WriteLine("Asynchronous operation completed with result: " + result);
}

public static async Task<string> GetDataFromWebAsync()
{
    // This method makes an asynchronous web request to get some data
    HttpClient client = new HttpClient();
    string result = await client.GetStringAsync("http://example.com");
    return result;
}
```
> In the above code, the `Main` method makes a call to the `GetDataFromWebAsync` method, which makes an asynchronous web request to retrieve some data. Since this operation is asynchronous, the execution of the program is not blocked and the program continues executing other operations while the web request is being made in the background. The program then waits for the result of the asynchronous operation using the `await` keyword, which does not block the execution of the program but instead waits for the result to become available before continuing to execute the next line of code.

</details>


8. Exception Handling
```
C# includes robust exception handling capabilities that allow developers to handle and recover from runtime errors in a structured manner.
```

9. Delegates and Events
```
C# supports the use of delegates and events, which are used for implementing callback functions and event-driven programming.
```

<details>
<summary>Click here for more</summary>

- A `delegate` is a type that represents a reference to a method with a particular parameter list and return type
```c#
public delegate int BinaryOperation(int x, int y);

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }
}

public static void Main()
{
    Calculator calculator = new Calculator();

    BinaryOperation operation = new BinaryOperation(calculator.Add);

    int result = operation(5, 3); // result = 8

    operation = new BinaryOperation(calculator.Subtract);

    result = operation(5, 3); // result = 2
}

```

- An `event` is a construct built on top of delegates that allows objects to be notified when an event occurs.
```c#
public class Button
{
    public event EventHandler Clicked;

    public void Click()
    {
        if (Clicked != null)
        {
            Clicked(this, EventArgs.Empty);
        }
    }
}

public static void Main()
{
    Button button = new Button();

    button.Clicked += OnButtonClicked;

    button.Click();
}

public static void OnButtonClicked(object sender, EventArgs e)
{
    Console.WriteLine("Button clicked!");
}

```

</details></br>

10. Security Features
```
C# includes security features such as code access security, which helps protect against malicious code execution, and cryptography, which allows for secure communication and data storage.
```

</details>

<details>
<summary>what is signature of method in c#</summary>

- The signature of a method in C# consists of its name and the types of its parameters. The return type of the method is not considered part of its signature.

</details>

