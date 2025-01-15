public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty to a non-zero value
        MyProperty = 10;
    }

    public void MyMethod() {
        // Check for a condition that could actually be true
        if (MyProperty > 5) {
            Console.WriteLine("MyProperty is greater than 5");
        } else {
            Console.WriteLine("MyProperty is not greater than 5");
        }
    }
} 