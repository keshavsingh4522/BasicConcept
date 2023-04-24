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