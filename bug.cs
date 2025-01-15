public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty to a non-zero value
        MyProperty = 10;
    }

    public void MyMethod() {
        if (MyProperty == 0) {
            // This code will never be executed because MyProperty is initialized to 10
            Console.WriteLine("MyProperty is zero");
        }
        // This code will always be executed
        Console.WriteLine("MyProperty is not zero");
    }
}