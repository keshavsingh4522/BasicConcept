# InterviewPreparation

<details>
<summary>Interface And Abstraction</summary>

Interface | Abstraction 
------ | ----- 
| A class can inherit from more than one interface. ex. ```public class AV : IAV1, IAV2, IAV3{} ``` | A class can extend only one abstract class. |
| Interface is not a class | Abstract is a class. |
| **Interface** keyword is used.  | **abstract** keyword is used to define abstract class. |
| In interfaces, the body is definitely not found. The body is created in the inherited subclass. | Methods in abstract classes can have bodies or are marked abstract and override in the inheriting class. |
| Interface are implemented | Abstract class are inherited. |
| Does not contain the constructor and static members. | Can contain the constructor and static members. |
| Does not contain the static members | Can contain the static members. |
| Allow multiple inheritance.| Abstract classes do not allow multiple inheritance |
| All elements in Interface must be implemented in subclass. | In abstract classes, only abstract elements must be overridden in subclasses. Unsigned members do not have to be in subclasses. In this way, code clutter is avoided by keeping only the common features in the subclasses. |
| An interface can not have access modifier, by default all is public. and we define these in implemented class. | All access modifier is accepted.  |
| A class can implement more than 1 interface. | A class can extends only one abstract  class. |

</details>

<details>
<summary>Filters</summary>
 
 - Authorization FIlter
 - Resource Filter
 - Action Filter
 - Result Filter
 - Exception Filter

![](https://camo.githubusercontent.com/4711bb74ccf3f761f71bec058afa51a2d7c5aae62b3a7d2ea384b36a04349955/68747470733a2f2f66346e33783663352e737461636b7061746863646e2e636f6d2f61727469636c652f776f726b696e672d776974682d66696c746572732d696e2d6173702d6e65742d636f72652d6d76632f496d616765732f312e706e67)

![](https://camo.githubusercontent.com/cc25260ca6c4b609ad9403e297a7a304b0395e03e3d3e4ca3726f0fc95f8fe17/68747470733a2f2f66346e33783663352e737461636b7061746863646e2e636f6d2f61727469636c652f776f726b696e672d776974682d66696c746572732d696e2d6173702d6e65742d636f72652d6d76632f496d616765732f322e706e67)

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

</details>