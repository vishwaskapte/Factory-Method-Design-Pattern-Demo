<h3>Factory Method Design Pattern in C#</h3>

Factory method design pattern is one of the most used design pattern in .NET. In this article, I will explain about how to implement factory method design pattern in C#.

Factory method design pattern comes under creational design pattern category of Gang of Four (GoF) design patterns. Basically, it solves the problem related to object creation.

First we will see what problem does factory pattern solves then we will see about how to implement factory pattern.



<h3>Problem Occurs When Fctory Pattern not Used</h3>

Let’s see an example code that generates various objects:

if(type == “PermanentEmployee")
{
  myObject = new PermanentEmployee();
}

if(type == “TemporaryEmployee")
{
  myObject = new TemporaryEmployee();
}

The above example generates objects of different classes after checking a condition. But the above code is having two issues:

Lot of new keyword: The above code implements lot of new keyword which increases your client code complexity and also increases maintenance requirement. If you will add one more condition, then one more new keyword will be required.

Client will know all the concrete objects types; if it is required to instantiate one more class then client should be required to know that class too.
Factory pattern provides solution for above mentioned problems. It helps you to create objects in a different way.


<h3>Factory Method Design Pattern</h3>
As the name Factory indicates that it will create something. This something is nothing but the objects. Factory method design pattern is a way to create object but the client or calling class will not know about how the objects were created. In factory pattern subclass decides about instantiation of a class.

<h3>Definition</h3>

“Define an interface for creating an object, but let subclasses decide which class to instantiate.”


<h3>Factory method design pattern in C# – Example implementation</h3>

IFactory: Interface

PerrmanentEmployee and TemporaryEmployee: Concrete Product classes

EmployeeFactory: creator

ConcreteEmployeeFactory: Concrete creator class

