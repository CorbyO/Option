# Option
Option to replace Nullable as in functional programming for Unity.

## Table of Contens

- [Getting started](#getting-started)
- [Serialization](#serialization)

# Getting started
```csharp
using Corby.Option;

void Func()
{ 
    // Default usage 
    {
        string helloString = "Hello";
        string worldString = null;
        
        var a = helloString.Some(); // Some<String>("Hello")
        var b = worldString.Some(); // None<String>() because worldString is null
        var c = "Option".Some(); // Some<String>("Option") by literal
        
        var printString = a switch
        {
            Some<string> some => some.Value,
            None<string> none => "None"
        };
        
        UnityEngine.Debug.log(printString); // print "Hello"
        UnityEngine.Debug.log(a); // print "Some<string>(Hello)"
        UnityEngine.Debug.log(b); // print "None<string>"
    }
    
    
    // safety usage without null exception for function
    {
        int[] array1 = new int[] { 1, 2, 3 };
        int[] array2 = null;
        
        Func<int[], Option<int>> GetLength = (array) => 
        {
            if (array == null) return None<int>.New;
            return array.Length.Some();
        }
        
        UnityEngine.Debug.log($"length: {GetLength(array1)}"); // print "length: Some<int>(3)"
        UnityEngine.Debug.log($"length: {GetLength(array2)}"); // print "length: None<int>"
    }
    
    
    // Four basic operations
    {
        int a = 3;
        Option<int> b = 7.Some();
        Option<int> c = None<int>.New;
        
        // Option<int> is change to int whan calculated
        UnityEngine.Debug.log($"{a.Add(b)}"); // print "a: 10"
        UnityEngine.Debug.log($"{a.Sub(c)}"); // print "a: 3" because None isn't calculated
        UnityEngine.Debug.log($"{b.Mul(a)}"); // print "a: 21"
        UnityEngine.Debug.log($"{b.Div(c)}"); // print "a: 7" because None isn't calculated
    }
}
```

# Serialization
![image](https://github.com/CorbyO/Option/assets/17669733/c6e738f0-28be-4257-948e-a7c8cdf2ba2d)  
This is a simple example of how to serialize a class or struct that contains Option.  
i don't found serialize for interface so you want to serialize the option, you use the SerializableOption class.

```csharp
// good
[Serializable]
public struct TestStruct
{
    public SerializableOption<Vector3> OptionVector3;
    public SerializableOption<Quaternion> OptionQuaternion;
    public SerializableOption<Transform> OptionTransform;
}

// bad: Serialize is fail because [Serializable] is not applied.
public struct TestStruct2
{
    public SerializableOption<int> i;
}

// good
[Serializable]
public class TestClass
{
    public SerializableOption<int> OptionInt;
    public SerializableOption<float> OptionFloat;
    public SerializableOption<string> OptionString;
    public SerializableOption<TestStruct> OptionTestStruct;
    public SerializableOption<TestStruct2> OptionTestStruct2;
}


public class TestComponent : MonoBehaviour
{
    public SerializableOption<TestClass> OptionTestClass;
    
    void Awake()
    {
        var option = OptionTestClass.Get(); // Some<TestClass> or None<TestClass>
    }
}
```