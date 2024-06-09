# Builder Pattern Example

This repository contains an example implementation of the Builder Pattern in C#. The Builder Pattern is a design pattern that separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

## Overview

The example demonstrates how to construct different types of `Computer` objects (e.g., Gaming Computer, Office Computer) using the Builder Pattern.

## Classes and Interfaces

### Computer

The `Computer` class represents the complex object that is being constructed.

```csharp
internal class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}, Storage: {Storage}";
    }
}
