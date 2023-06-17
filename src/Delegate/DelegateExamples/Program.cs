using DelegateExamples;
using static DelegateExamples.Start;

// Action delegate
Action<string> print = (x) => Console.WriteLine(x);

//MyDelegate del = Start.Method1;
MyDelegate del = new(Start.Method1);  // using new keyword
MyDelegate del1 = Start.Method2;  // directly assign the method.

// MultiCast delegate =>  +,-,+=,-=
del += del1;

// Lambda Expression
MyDelegate del3 = (message) => print("Lambda Exp > " + message.ToLower() + "\n");

// Anonymous method
MyDelegate del4 = delegate
{
    print("Anonymous method");
};


// Invoke delegates

//1. using delegate as calling the function
del("AbvSdg");
del1("cDeed");
del3("gdH");
del4("iJfe");

// 2. Using invoke
del.Invoke("keshav");

//3. passing as paramter in function

//4. Generic delegate

#region Function delegate
Func<int, int, int> Sum = Calculator.Addition;
Sum += Calculator.Subtraction;

// It will get result of last delegate.
int result = Sum(6, 3);

Console.WriteLine("Result: {0}", result);

#endregion

#region Predicate Delegate
print("__START Predicate__\n");
Predicate<int> isEvenLambdaExpression = (x) => (x & 1) == 0;  // Lambda expession.
Predicate<int> isEvenAnonymous = delegate (int x) { return (x & 1) == 0; }; // Anonymous Method.
Predicate<int> isEvenMethod_1 = Calculator.IsEven;  // Directly by method.
Predicate<int> isEvenMethod_2 = new(Calculator.IsEven); // using new and method.

Console.WriteLine("isEvenLambdaExpression(3): {0}", isEvenLambdaExpression(3));
Console.WriteLine("isEvenLambdaExpression(8): {0}", isEvenLambdaExpression(8));
Console.WriteLine("isEvenAnonymous(313): {0}", isEvenAnonymous(313));
Console.WriteLine("isEvenAnonymous(3134): {0}", isEvenAnonymous(3134));
Console.WriteLine("isEvenMethod_1(79): {0}", isEvenMethod_1(79));
Console.WriteLine("isEvenMethod_1(798): {0}", isEvenMethod_1(798));
Console.WriteLine("isEvenMethod_2(19): {0}", isEvenMethod_2(19));
Console.WriteLine("isEvenMethod_2(196): {0}", isEvenMethod_2(196));

print("\n__END Predicate__\n");
#endregion

#region Event
print("__START Event__\n");
// Event using delegate
static void bl_ProcessCompleted()
{
    Console.WriteLine("Process Completed!");
}

ProcessBusinessLogic processBusinessLogic = new();
processBusinessLogic.ProcessCompleted += bl_ProcessCompleted;
processBusinessLogic.StartProcess();

print("__END Event__\n");

// Using built in event handler
print("__START Event 2__\n");
void bl_ProcessCompleted2(object? sender, EventArgs e)
{
    Console.WriteLine("Sender: {0}", sender);
    Console.WriteLine("EventArgs: {0}", e.ToString());
    print("Process2 Completed!");
}
ProcessBusinessLogic2 processBusinessLogic2 = new();
processBusinessLogic2.ProcessCompleted += bl_ProcessCompleted2;

processBusinessLogic2.StartProcess();
print("__END Event 2__\n");
#endregion