public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Correctly accessing and modifying the field via the property
        MyProperty = 10;
    }
}