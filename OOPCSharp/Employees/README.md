## Containment/Delegation 

Exposing the functionality of the contained object to the outside world requires delegation. 
*Delegation* is simply the act of adding public members to the containing class (Employee) that use the contained object's (BenefitPackage) functionality.


## Nested Types

In C#, it is possible to define a type directly within the scope of a class or structure. When you have done so, the nested (inner) type is considered a member of the nesting (outer) class.
A public nested type can be used by anybody, while a private nested type can be used by members of the containing class.


## Virtual and Override

If a base class wants to define a method that may be overriden by a subclass, it must mark the method with the **virtual** keyword.
When a subclass wants to change the implementation details of a virtual method, it does so using the **override** keyword.


## Casting Rules

When two classes are related by an "is-a" relationship, it is always safe to store a derived object within a base class reference.
Formally, this is called an *Implicit cast*.