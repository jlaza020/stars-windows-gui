# Creating Windows GUI Apps with C# & .NET

## FAQ

### What is C#?

C# is a programming language that is designed by Microsoft for building a variety of applications that run on the .NET Framework. C# is simple, powerful, type-safe, and object-oriented. The many innovations in C# enable rapid application development while retaining the expressiveness and elegance of C-style languages.

### What is the .NET framework, anyway?

.NET is a software framework designed by Microsoft used to make applications primarily on the Windows platform. It has many, many features. Some of its most praised features are its large class library and language interoperability (e.g., a programmer can code a class in C# and a Visual Basic programmer can import the class and use it)! .NET's Framework Class Library (FCL) and Common Language Runtime (CLR) provides a combination of things like security, memory management, exception handling, user interface, data access, database connectivity, cryptography, web application development, and more!

## Prerequisites

These are the things you need to have before we start:

* A laptop running Windows
* [Visual Studio](https://www.visualstudio.com/downloads/?rr=https%3A%2F%2Fwww.google.com%2F) (this takes a very long time to install, so please come prepared)

Bonuses:

* [Git](https://git-scm.com/downloads)
 
## Tutorial

### Basics

C# syntax is very similar to Java. It only has some slightly annoying differences. There are also some C#-like things that are an improvement of Java's syntax. For example, properties are declared like so:

``` c#
public class Car {

    string Color { get; set; }
    int NumOfWheels { get; set; }

}
```

### Overview

* Create MainForm
* Init database in Load Event Handler
* Create and Design LoginForm
    * Color and Font
    * Username and Password Inputs
    * Login Button
    * Event Handler to Login User
    * Error Provider
    * Help Provider
    * Size
* Design MainForm
    * Color and Font
    * Buttons/Labels/Panels/TreeView
    * Size/Anchoring/Docking
    * Data Binding
    * Event Handlers for Buttons
    * Initialize TreeView
    * Event Handler for TreeView
    * Finish Data Binding

### Screenshots

![Alt text](http://dat/login.jpg "Optional title")
