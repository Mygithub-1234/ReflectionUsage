**What is Reflection in C#?**

Reflection is needed when you want to determine or inspect the content of an assembly. Here, content means the metadata of an assembly like what are the methods in that assembly, what are the properties in that assembly, are they public, are they private, etc.

For example, one of the biggest implementations of Reflection is Visual Studio itself. Suppose, in visual studio, we create an object of the String class, and when we press obj. then visual studio intelligence shows all the properties, methods, fields, etc. of that object as shown in the below image. And this is possible because of the Reflection in C#.

What are the real-time uses of Reflection in C#?
If you are creating applications like Visual Studio Editors where you want to show internal details i.e. Metadata of an object using Intelligence.
In unit testing sometimes we need to invoke private methods to test whether the private members are working properly or not.
Sometimes we would like to dump properties, methods, and assembly references to a file or probably show it on a screen.
Late binding can also be achieved by using Reflection in C#. We can use reflection to dynamically create an instance of a type, about which we don’t have any information at compile time. So, Reflection enables us to use code that is not available at compile time.
Consider an example where we have two alternate implementations of an interface. You want to allow the user to pick one or the other using a config file. With reflection, you can simply read the name of the class whose implementation you want to use from the config file and instantiate an instance of that class. This is another example of late binding using reflection.
