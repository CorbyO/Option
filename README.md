# Option
Option to replace Nullable as in functional programming for Unity.

## Table of Contens

- [Getting started](#getting-started)
- [Serialization](#serialization)

# Install
# Via Git
add `"com.corby.option": "https://github.com/CorbyO/Option.git"` to `Packages/manifest.json`.
# Via OpenUPM
```
openupm add com.corby.option
```

# Getting started

### Initialize
```csharp
Option<int> num = new(); // None<int>
Option<int> num = 3.ToSome(); // Some<>(3)
Option<Transform> parent = transform.parent.ToOption(); // Some<> or None 
```

### Return without null
```csharp
public static Option<Transform> GetParent<T>(this Transform transform)
{
    return transform.parent.ToOption();
}
```

### Unwarpping
```csharp
var parentName = transform.GetParent().Unwrap() switch
{
    Some<Transform> parent => parent.name,
    None<Transform> => "None"
};
```



# Serialization
![image](https://github.com/CorbyO/Option/assets/17669733/6be717ce-b181-4b86-9238-a5d00fa900b4)

This is a simple example of how to serialize a class or struct that contains Option.

```csharp
[Serializable]
public struct TestStruct
{
    public Option<int> Number;
    public Option<string> Name;
    public Option<Vector3> Position;
}

[Serializable]
public class TestClass
{
    public Option<Sprite> Sprite;
    public Option<List<int>> Numbers;
}


public class TestComponent : MonoBehaviour
{
    public Option<TestStruct> Struct;
    public Option<TestClass> Class;
}
```
