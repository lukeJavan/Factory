# This is a demo application for using the Factory pattern in C#

## In this example (taken from refactoring guru) we are creating a logistics application factory with 2 different cases, Sea and Road transport.

The Factory Method pattern suggests that you replace direct object construction calls (using the new operator) with calls to a special factory method.
The objects are still created via the new operator, but it’s being called from within the factory method.
Objects returned by a factory method are often referred to as products.

The base factory method in this case is inside an abstract class as we may require or want some deafult behaviour that we can ovveride in the subclasses.
In this example there is no default behaviour for creation.

This pattern follows the Open/Closed principle and the Single Responsibility Principle.
