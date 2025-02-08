# Direct Access of Private Field Instead of Public Property

This repository demonstrates a subtle bug in C# where direct access of a private field bypasses any logic or validation within a property's setter.

## The Bug

The `BuggyCode.cs` file illustrates the problematic code.  The `MyMethod` function directly modifies the `_myField` instead of using the `MyProperty` property. This can lead to inconsistencies or unintended behavior if the property has any validation or side effects (e.g. event triggering, logging, or additional computations). 

## The Solution

The `FixedCode.cs` shows the corrected code where `MyMethod` properly uses the `MyProperty` setter.  This ensures that any logic within the property's `set` accessor is correctly executed.

## How to reproduce

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Run the `BuggyCode` and `FixedCode` examples to observe the difference in behavior. (You'll likely need to add some diagnostic output (Console.WriteLine) to see the effects).