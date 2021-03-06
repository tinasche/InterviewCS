# CSharp Interview questions and answers
[Github repo](https://github.com/tinasche/InterviewCS) for this content.
## Part 1: Basics

1. What is a class? What is a sealed class? What is a partial class?
A class is a **template** for creating objects.
```
class A 
{
    public int Id { get; set; } = default;
    public string Name { get; set; } = String.empty;

    public void GetName()
    {
        return this.Name;
    }
}
```
A sealed class is a class with the *sealed* keyword used to restrict a class from being inherited from.
A partial class is a class with the *partial* keyword used to split a class into multiple files. At runtime the files are organised as one file so method and variable names must be unique across the partial class files.

2. List and briefly explain the main principles of object-oriented programming?
<br/>**Abstraction**: A technique used to provide methods of interacting with a component without revealing the inner-workings of said component. 
<br/>**Polymorphism**: The ability of an object/type to take multiple forms. Compile-time (method overloading) and run-time (method overriding) polymorphism .
<br/>**Inheritance**: The ability of a type to attain the attributes of another type. 
<br/>**Encapsulation**: A technique of grouping related members of a type together.

3. What is an interface? A form of abstract method with **only** abstract members as method signature i.e., no method definition or property instantiation. It enforces the classes which *implement* the interface to define the members described therein.

4. Define a constructor and its types. Define a destructor.
<br/>A constructor is a method that is used to instantiate the state of an object defined using the *new* keyword. The types of constructors are: default (auto-generated by the runtime), static (instantiate static members), parameterised (default constructor with parameters).
<br/>A destructor is a method that cleans up memory by triggering garbage collection on its type.

5. Briefly describe the CSharp Common Type System.
<br/>Every variable, constant and expression that evaluates to some value has a type. Information contained in a type may include:
- the base type is inherits from
- the interface it implements
- the members (methods, fields, events e.t.c)
- the storage space that a variable of the type requires
<br/>All types inherit from the *System.Object* type. Types are either 
<br/>a. value types (have direct access to values) e.g. enums and struct types or 
<br/>b. reference types (have a memory location for values).  

6. What is a virtual method and how is it different from an abstract method?
<br/>A virtual method is a method that uses the *virtual* keyword which denotes that it can be overriden by a derived class implementation. It must have a default implementation.
<br/>An abstract method is a method that uses the *abstract* keyword to describe a method signature. It is contained within an abstract class and must be implemented by a class which inherits from it.

7. What is boxing and unboxing? The conversion of a type from value to reference is called boxing. The conversion of a type from reference to value is called unboxing. 

8. What is a delegate?
9. Describe Dependency Injection.
10. Describe the access modifiers in CSharp.
11. What is an array?
12. What is Linq?
13. What is Reflection?
14. Explain code compilation in CSharp.
15. Describe the CLR and .NET architecture.