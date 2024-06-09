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

IBuilder
The IBuilder interface declares the methods for creating the parts of the Computer object.

public interface IBuilder
{
    void StartUpOperations();
    void BuildCPU();
    void BuildGPU();
    void BuildRAM();
    void BuildStorage();
    Computer GetComputer();
}

Concrete Builders
Concrete builders implement the IBuilder interface to construct and assemble the parts of the Computer object.

GamingComputerBuilder
