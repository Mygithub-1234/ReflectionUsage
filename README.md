**What is Reflection in C#?**

Reflection is needed when you want to determine or inspect the content of an assembly. Here, content means the metadata of an assembly like what are the methods in that assembly, what are the properties in that assembly, are they public, are they private, etc.

For example, one of the biggest implementations of Reflection is Visual Studio itself. Suppose, in visual studio, we create an object of the String class, and when we press obj. then visual studio intelligence shows all the properties, methods, fields, etc. of that object as shown in the below image. And this is possible because of the Reflection in C#.

**What are the real-time uses of Reflection in C#?**

If you are creating applications like Visual Studio Editors where you want to show internal details i.e. Metadata of an object using Intelligence.

In unit testing sometimes we need to invoke private methods to test whether the private members are working properly or not.

Sometimes we would like to dump properties, methods, and assembly references to a file or probably show it on a screen.

Late binding can also be achieved by using Reflection in C#. We can use reflection to dynamically create an instance of a type, about which we don’t have any information at compile time. So, Reflection enables us to use code that is not available at compile time.

Consider an example where we have two alternate implementations of an interface. You want to allow the user to pick one or the other using a config file. With reflection, you can simply read the name of the class whose implementation you want to use from the config file and instantiate an instance of that class. This is another example of late binding using reflection.


**Var in C#**

var is known as a statically typed variable, meaning that the data type of these variables is identified at compile time, which is done based on the type of value with which these variables are initialized.

var in C# was introduced as part of C# 3.0.

In the case of var, the variable’s data type is identified by the compiler at the compilation time only.

In the case of var, it is mandatory to initialize the variable at the time of its declaration so that the compiler comes to know the variable’s data type according to the right-hand side value assigned to it.

It will throw an error if the variable does not initialize at the time of its declaration.
We will get intelligence support in the visual studio.

Var cannot be used to declare method parameters and method return type in C#. It can only be used as a local variable declaration inside a function.

Var is early bounded. This means the compiler decides the type of variable declared at compile time.

**Dynamic in C#**

Dynamic is known as a dynamically typed variable which means that the data type of these variables is identified at runtime, which is done based on the type of value that these variables are initialized with.

Dynamic in C# was introduced in C#4.0.

In the case of dynamic, the data type of variable is identified by the CLR at run time.

In the case of dynamic, it is not mandatory to initialize the variable at the time of its declaration.

It will not throw an error if the variable does not initialize at the time of its declaration.

We will not get any intelligence support in the visual studio.
Dynamic can be used to declare method parameters and method return type in C#. It can also be used as a local variable declaration inside a function.

Dynamic is Late Bounded. This means the CLR decides the type of variable declared at runtime time.
