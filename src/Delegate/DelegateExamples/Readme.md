# Delegate

- It is a reference type that represents a method with a specific signature.
- It allows you to store a reference to a method and call that method later, enabling you to pass methods as parameters, return them from other methods, and assign them to variables.
- Delegates are similar to function pointers in C++, but they are type-safe and secure.

There are three steps involved while working with delegates:

    Declare a delegate
    Set a target method
    Invoke a delegate

A delegate can be declared using the delegate keyword followed by a function signature, as shown below.

Delegate Syntax

```c#
[access modifier] delegate [return type] [delegate name]([parameters])
```
