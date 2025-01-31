public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 10; // Initialize MyProperty
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; // Now MyProperty is guaranteed to have a value
    }
}