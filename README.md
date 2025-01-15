# Unreachable Code Due to Incorrect Initialization Assumption

This repository demonstrates a common C# coding error where a developer incorrectly assumes the initial value of a variable and writes code that will never execute because of a different initialization.

## Bug Description
The `MyClass` class has a property `MyProperty` that is initialized to 10 in the constructor. However, the `MyMethod` method includes a conditional statement that checks if `MyProperty` is 0. Because of the constructor's initialization, this condition will always be false, making the code within the `if` statement unreachable.

## Bug Solution
The solution involves reviewing and correcting the assumptions about variable initialization and flow of logic.   Either change the condition to a value that can actually be true, or modify the logic to handle the different scenario.