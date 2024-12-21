#region first task 
//using System;

//enum Weekdays
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday
//}

//class Program
//{
//    static void Main()
//    {
//        foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
//        {
//            Console.WriteLine($"{day} = {(int)day}");
//        }
//    }
//}

//Explicitly assigning values to enum members can help maintain clear and consistent code,
//    especially when dealing with flags or when you need specific integer values for compatibility or serialization purposes.

#endregion

#region second task

//using System;

//enum Grades : short
//{
//    F = 1,
//    D,
//    C,
//    B,
//    A
//}

//class Program
//{
//    static void Main()
//    {
//        foreach (Grades grade in Enum.GetValues(typeof(Grades)))
//        {
//            Console.WriteLine($"{grade} = {(short)grade}");
//        }
//    }
//}

//If you assign a value to an enum member that exceeds the underlying type's range, 
//    it will cause a compilation error as the value cannot be represented by the specified underlying type.

#endregion

#region third task
//using System;

//class Person
//{
//    public string Name { get; set; }
//    public string Department { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person1 = new Person { Name = "Alice", Department = "HR" };
//        Person person2 = new Person { Name = "Bob", Department = "IT" };

//        Console.WriteLine($"{person1.Name} works in {person1.Department}");
//        Console.WriteLine($"{person2.Name} works in {person2.Department}");
//    }
//}

/* The virtual keyword allows a property to be overridden in a derived class, providing flexibility for altering behavior in the subclass.*/

#endregion

#region fourth task
//using System;

//class Parent
//{
//    public virtual int Salary { get; set; }
//}

//class Child : Parent
//{
//    public sealed override int Salary { get; set; }

//    public void DisplaySalary()
//    {
//        Console.WriteLine($"Salary: {Salary}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child child = new Child { Salary = 50000 };
//        child.DisplaySalary();
//    }
//}

#endregion

#region fifth task
//using System;

//class Parent
//{
//    public virtual int Salary { get; set; }
//}

//class Child : Parent
//{
//    public sealed override int Salary { get; set; }

//    public void DisplaySalary()
//    {
//        Console.WriteLine($"Salary: {Salary}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child child = new Child { Salary = 50000 };
//        child.DisplaySalary();
//    }
//}

//You can't override a sealed property or method because the sealed keyword prevents further modification, ensuring the integrity of the implementation in derived classes.

#endregion

#region sixth task
//using System;

//class Utility
//{
//    public static double CalculatePerimeter(double length, double width)
//    {
//        return 2 * (length + width);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double perimeter = Utility.CalculatePerimeter(5, 3);
//        Console.WriteLine($"Perimeter: {perimeter}");
//    }
//}

//The static keyword allows you to access a method without creating an instance of the class, which can be useful for utility methods or when you don't need to maintain state.

#endregion

#region seventh task
//using System;

//class ComplexNumber
//{
//    public double Real { get; set; }
//    public double Imaginary { get; set; }

//    public ComplexNumber(double real, double imaginary)
//    {
//        Real = real;
//        Imaginary = imaginary;
//    }

//    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
//    {
//        double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
//        double imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
//        return new ComplexNumber(real, imaginary);
//    }

//    public override string ToString()
//    {
//        return $"{Real} + {Imaginary}i";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ComplexNumber c1 = new ComplexNumber(1, 2);
//        ComplexNumber c2 = new ComplexNumber(3, 4);

//        ComplexNumber result = c1 * c2;
//        Console.WriteLine($"Multiplication Result: {result}");
//    }
//}

//No, you cannot overload all operators in C#. Certain operators, like && and ||, cannot be overloaded to ensure consistent logical behavior and maintain readability and predictability in the code

#endregion

#region eighth task
//using System;

//enum Gender : byte
//{
//    Male,
//    Female
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine($"Size of Gender enum: {sizeof(Gender)} bytes");
//        Console.WriteLine($"Size of default int: {sizeof(int)} bytes");
//    }
//}

//Changing the underlying type of an enum is useful when you need to optimize memory usage, especially in large collections or when the enum values are within a smaller range that a smaller data type can accommodate.

#endregion

#region ninth task
//using System;

//class Utility
//{
//    public static double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }

//    public static double FahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double celsius = 25;
//        double fahrenheit = Utility.CelsiusToFahrenheit(celsius);
//        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

//        fahrenheit = 77;
//        celsius = Utility.FahrenheitToCelsius(fahrenheit);
//        Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
//    }
//}

//A static class cannot have instance constructors because it is not meant to be instantiated. All members of a static class are also static, and the class itself is used to group related static methods and properties.
#endregion

#region tenth task
//using System;

//enum Grades
//{
//    F = 1,
//    D,
//    C,
//    B,
//    A
//}

//class Program
//{
//    static void Main()
//    {
//        string input = "B";
//        if (Enum.TryParse<Grades>(input, out Grades grade))
//        {
//            Console.WriteLine($"Parsed enum: {grade}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid input");
//        }
//    }
//}

//Enum.TryParse allows for safe parsing of strings to enum values, handling invalid inputs gracefully without throwing exceptions. This approach enhances robustness and readability of the code.
#endregion

#region eleventh task
//using System;

//class Employee
//{
//    public string Name { get; set; }
//    public int Id { get; set; }

//    public override bool Equals(object obj)
//    {
//        if (obj is Employee other)
//        {
//            return this.Id == other.Id;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Id.GetHashCode();
//    }
//}

//class Helper2<T>
//{
//    public static int SearchArray(T[] array, T value)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Equals(value))
//            {
//                return i;
//            }
//        }
//        return -1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee[] employees = {
//            new Employee { Name = "Alice", Id = 1 },
//            new Employee { Name = "Bob", Id = 2 }
//        };

//        Employee target = new Employee { Id = 2 };
//        int index = Helper2<Employee>.SearchArray(employees, target);
//        Console.WriteLine($"Found employee at index: {index}");
//    }
//}

//Overriding Equals allows you to provide a custom definition for equality comparison in classes and structs. By default, == checks for reference equality in classes and value equality in structs. Overriding == lets you define equality checks based on your custom logic for both structs and classes. However, == requires both sides of the operator to be of the same type, whereas Equals can compare with any object type.

//Why is overriding ToString beneficial when working with custom classes?
//Overriding ToString in custom classes provides a meaningful string representation of the object, which can be very useful for debugging, logging, and displaying information about the object.

#endregion

#region twelfth task
//using System;

//class Helper
//{
//    public static T Max<T>(T a, T b) where T : IComparable<T>
//    {
//        return a.CompareTo(b) > 0 ? a : b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(Helper.Max(3, 5));          // integers
//        Console.WriteLine(Helper.Max(3.7, 2.1));      // doubles
//        Console.WriteLine(Helper.Max("apple", "pear")); // strings
//    }
//}


//Yes, generics can be constrained to specific types using where clauses. For example, to constrain a generic type to classes implementing IComparable
#endregion

#region thirteenth task
//using System;

//class Helper2<T>
//{
//    public static void ReplaceArray(T[] array, T oldValue, T newValue)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Equals(oldValue))
//            {
//                array[i] = newValue;
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 2, 3, 4 };
//        string[] stringArray = { "apple", "banana", "apple", "cherry" };

//        Helper2<int>.ReplaceArray(intArray, 2, 5);
//        Helper2<string>.ReplaceArray(stringArray, "apple", "orange");

//        Console.WriteLine(string.Join(", ", intArray));
//        Console.WriteLine(string.Join(", ", stringArray));
//    }
//}

//Generic methods are defined within a class and allow for type parameters specific to that method, providing flexibility within a non-generic class.
//Generic classes define type parameters that apply to the entire class, allowing the class to work with any data type specified when an object is created.

#endregion

#region fourteenth task
//using System;

//struct Rectangle
//{
//    public double Length { get; set; }
//    public double Width { get; set; }

//    public static void Swap(ref Rectangle r1, ref Rectangle r2)
//    {
//        Rectangle temp = r1;
//        r1 = r2;
//        r2 = temp;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rect1 = new Rectangle { Length = 5, Width = 3 };
//        Rectangle rect2 = new Rectangle { Length = 8, Width = 6 };

//        Console.WriteLine($"Before Swap: rect1 = {rect1.Length}, {rect1.Width}; rect2 = {rect2.Length}, {rect2.Width}");
//        Rectangle.Swap(ref rect1, ref rect2);
//        Console.WriteLine($"After Swap: rect1 = {rect1.Length}, {rect1.Width}; rect2 = {rect2.Length}, {rect2.Width}");
//    }
//}


//Using a generic swap method provides a reusable and type-safe way to swap values of any type, reducing code duplication and improving maintainability.
#endregion

#region fifteenth task
//using System;

//class Department
//{
//    public string Name { get; set; }

//    public override bool Equals(object obj)
//    {
//        if (obj is Department other)
//        {
//            return this.Name == other.Name;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Name.GetHashCode();
//    }
//}

//class Employee
//{
//    public string Name { get; set; }
//    public Department Department { get; set; }

//    public override bool Equals(object obj)
//    {
//        if (obj is Employee other)
//        {
//            return this.Department.Equals(other.Department);
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Department.GetHashCode();
//    }
//}

//class Helper2<T>
//{
//    public static int SearchArray(T[] array, T value)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Equals(value))
//            {
//                return i;
//            }
//        }
//        return -1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Department hr = new Department { Name = "HR" };
//        Department it = new Department { Name = "IT" };

//        Employee[] employees = {
//            new Employee { Name = "Alice", Department = hr },
//            new Employee { Name = "Bob", Department = it }
//        };

//        Employee target = new Employee { Department = it };
//        int index = Helper2<Employee>.SearchArray(employees, target);
//        Console.WriteLine($"Found employee in department at index: {index}");
//    }
//}

//Overriding Equals allows you to provide a custom definition for equality comparison in classes and structs. By default, == checks for reference equality in classes and value equality in structs. Overriding == lets you define equality checks based on your custom logic for both structs and classes. However, == requires both sides of the operator to be of the same type, whereas Equals can compare with any object type.

#endregion

#region sixteenth task
//using System;

//struct Circle
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public Circle(double radius, string color)
//    {
//        Radius = radius;
//        Color = color;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Circle other)
//        {
//            return this.Radius == other.Radius && this.Color == other.Color;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Radius.GetHashCode() ^ Color.GetHashCode();
//    }

//    public static bool operator ==(Circle c1, Circle c2)
//    {
//        return c1.Equals(c2);
//    }

//    public static bool operator !=(Circle c1, Circle c2)
//    {
//        return !c1.Equals(c2);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle1 = new Circle(5, "Red");
//        Circle circle2 = new Circle(5, "Red");
//        Circle circle3 = new Circle(7, "Blue");

//        Console.WriteLine(circle1 == circle2); // True
//        Console.WriteLine(circle1.Equals(circle2)); // True
//        Console.WriteLine(circle1 == circle3); // False
//        Console.WriteLine(circle1.Equals(circle3)); // False
//    }
//}



//class CircleClass
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public CircleClass(double radius, string color)
//    {
//        Radius = radius;
//        Color = color;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is CircleClass other)
//        {
//            return this.Radius == other.Radius && this.Color == other.Color;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Radius.GetHashCode() ^ Color.GetHashCode();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        CircleClass circle1 = new CircleClass(5, "Red");
//        CircleClass circle2 = new CircleClass(5, "Red");
//        CircleClass circle3 = new CircleClass(7, "Blue");

//        Console.WriteLine(circle1 == circle2); // Compilation error, `==` not overloaded for classes
//        Console.WriteLine(circle1.Equals(circle2)); // True
//        Console.WriteLine(circle1 == circle3); // Compilation error, `==` not overloaded for classes
//        Console.WriteLine(circle1.Equals(circle3)); // False
//    }
//}



//By default, == is not implemented for structs to avoid unintended consequences of shallow comparisons.
//Structs often represent complex types with multiple fields, and the default behavior might not reflect a meaningful equality comparison.
//Implementing == explicitly ensures that the comparison logic is intentionally defined by the developer, accounting for all relevant fields.
//This helps avoid bugs and ensures that comparisons are performed as intended.


#endregion

#region seventeenth task
//using System;

//public static class ArrayUtils
//{
//    public static T[] ReverseArray<T>(T[] array)
//    {
//        T[] reversed = new T[array.Length];
//        for (int i = 0; i < array.Length; i++)
//        {
//            reversed[i] = array[array.Length - 1 - i];
//        }
//        return reversed;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 5 };
//        string[] stringArray = { "apple", "banana", "cherry" };

//        intArray = ArrayUtils.ReverseArray(intArray);
//        stringArray = ArrayUtils.ReverseArray(stringArray);

//        Console.WriteLine("Reversed int array: " + string.Join(", ", intArray));
//        Console.WriteLine("Reversed string array: " + string.Join(", ", stringArray));
//    }
//}

#endregion

#region eighteenth task
//using System;

//public class Stack<T>
//{
//    private T[] items;
//    private int currentIndex = -1;
//    private int capacity;

//    public Stack(int capacity)
//    {
//        this.capacity = capacity;
//        items = new T[capacity];
//    }

//    public void Push(T item)
//    {
//        if (currentIndex >= capacity - 1)
//        {
//            throw new InvalidOperationException("Stack overflow");
//        }
//        items[++currentIndex] = item;
//    }

//    public T Pop()
//    {
//        if (currentIndex < 0)
//        {
//            throw new InvalidOperationException("Stack underflow");
//        }
//        return items[currentIndex--];
//    }

//    public T Peek()
//    {
//        if (currentIndex < 0)
//        {
//            throw new InvalidOperationException("Stack underflow");
//        }
//        return items[currentIndex];
//    }

//    public bool IsEmpty()
//    {
//        return currentIndex == -1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Stack<int> intStack = new Stack<int>(5);
//        intStack.Push(1);
//        intStack.Push(2);
//        intStack.Push(3);
//        Console.WriteLine("Top element: " + intStack.Peek());
//        Console.WriteLine("Popped element: " + intStack.Pop());
//        Console.WriteLine("Top element after pop: " + intStack.Peek());
//    }
//}

#endregion

#region nineteenth task
//using System;

//public static class ArrayUtils
//{
//    public static T Max<T>(T[] array) where T : IComparable<T>
//    {
//        if (array == null || array.Length == 0)
//        {
//            throw new ArgumentException("Array is null or empty");
//        }

//        T max = array[0];
//        foreach (T item in array)
//        {
//            if (item.CompareTo(max) > 0)
//            {
//                max = item;
//            }
//        }
//        return max;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 5 };
//        Console.WriteLine("Max int value: " + ArrayUtils.Max(intArray));

//        string[] stringArray = { "apple", "banana", "cherry" };
//        Console.WriteLine("Max string value: " + ArrayUtils.Max(stringArray));
//    }
//}

#endregion

