# C Sharp Notes #

## Sections
---
- [Classes](#classes)
- [Routing](#routing)
- [Data Flow](#data-flow)
- [ViewBag](#viewbag)
- [View Models](#view-models)
- [LINQ](#linq)
---



## Classes

### Below is a general template for creating classes in C#

```csharp
    using System;

    namespace ProjectName
    {
        public class Demo //Class Declaration - class name along with public modifier
        {
            public string Attribute1; //public string attribute

            public bool Attribute2; //public boolean attribute

            private int Attribute3; //private integer attribute
        }

        public Demo(string att1, bool attr2, int attr3) // Class Constructor with parameters
        {
            Attribute1 = att1;

            Attribute2 = attr2;

            Attribute3 = attr3;
        }
    }
```

1. Classes - Classes provide a template for each instance of an object created by that class.

2. Ojects - Objects are one single representation of the class it was created from unlike classes that can represent many instances of an object.

3. Class Methods -

4. Public Access Modifier - Public access modifiers allow for direct {get;}ting and {set;}ting of object attributes by hard code input or other methods in general.

5. Private Access Modifier - Private access modifiers provide a slight level of security prevent user manipulation of data. They allow for different methods to have control of the {get;} and {set;} functionalities to that method.

    - With a {get;} modifier that method would only be allowed to retrieve the information regarding that attribute but not change it.

    - With a {set;} modifier that method would be allowed to change the stored data but would not be able to retrieve it.


 ## Four Pillars of OOP

1. Abstraction - 

2. Polymorphism - 

3. Inheritance -

4. Encapsulation - 

## Routing

## Data Flow
1. Models

2. Views

3. Controllers 

## ViewBag

## View Models

## LINQ

