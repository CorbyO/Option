# Option
Option to replace Nullable as in functional programming for Unity.

## Table of Contens

- [Getting started](#getting-started)

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