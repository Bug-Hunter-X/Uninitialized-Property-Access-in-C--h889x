# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing a property before it's been initialized.  The code showcases a scenario where an uninitialized property is used in a calculation, which can lead to unexpected results (e.g., a default value of 0 being used instead of an intended value).

## Bug Description
The `ExampleClass` has a property `MyProperty` which is not explicitly initialized in the constructor.  The `MyMethod` attempts to use this property in a calculation without first assigning it a value.  This can lead to unpredictable results depending on the default value for the property type.

## Solution
The solution involves initializing the `MyProperty` either in the constructor or before accessing it in `MyMethod`.  This ensures the property has a defined value when it's used in calculations.