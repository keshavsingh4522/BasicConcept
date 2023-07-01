namespace InterviewQuestions;

public class A
{
    public int Add(int x, int y) => x + y;
}

public class B : A
{
    /*
     * By adding the `new` keyword in the method declaration in class B, 
     * you're telling the compiler that you're aware of the method hiding and you want to intentionally hide the base class method. 
     * This will also make the code less error-prone and easier to understand for other developers.
     */
    // public new int Add(int x, int y) => x * y;
    public int Add(int x, int y) => x * y;
}