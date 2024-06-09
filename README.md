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

internal class GamingComputerBuilder : IBuilder
{
    private Computer computer;

    public GamingComputerBuilder()
    {
        computer = new Computer();
    }

    public void StartUpOperations()
    {
        // Initialize or reset the computer object if needed
        computer = new Computer();
    }

    public void BuildCPU()
    {
        computer.CPU = "High-end Gaming CPU";
    }

    public void BuildGPU()
    {
        computer.GPU = "High-end Gaming GPU";
    }

    public void BuildRAM()
    {
        computer.RAM = "32GB Gaming RAM";
    }

    public void BuildStorage()
    {
        computer.Storage = "1TB NVMe SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

OfficeComputerBuilder

internal class OfficeComputerBuilder : IBuilder
{
    private Computer computer;

    public OfficeComputerBuilder()
    {
        computer = new Computer();
    }

    public void StartUpOperations()
    {
        // Initialize or reset the computer object if needed
        computer = new Computer();
    }

    public void BuildCPU()
    {
        computer.CPU = "Mid-range Office CPU";
    }

    public void BuildGPU()
    {
        computer.GPU = "Integrated GPU";
    }

    public void BuildRAM()
    {
        computer.RAM = "16GB Office RAM";
    }

    public void BuildStorage()
    {
        computer.Storage = "512GB SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
Manager
The Manager class directs the construction process using the builder interface.

internal class Manager
{
    protected readonly IBuilder builder;

    public Manager(IBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructComputer()
    {
        builder.StartUpOperations();
        builder.BuildCPU();
        builder.BuildGPU();
        builder.BuildRAM();
        builder.BuildStorage();
    }

    public Computer GetComputer()
    {
        return builder.GetComputer();
    }
}

Usage Example
Here is an example of how to use the Builder Pattern to construct different types of computers.

class Program
{
    static void Main(string[] args)
    {
        // Constructing a gaming computer
        IBuilder gamingBuilder = new GamingComputerBuilder();
        Manager gamingManager = new Manager(gamingBuilder);
        gamingManager.ConstructComputer();
        Computer gamingComputer = gamingManager.GetComputer();
        Console.WriteLine("Gaming Computer: " + gamingComputer);

        // Constructing an office computer
        IBuilder officeBuilder = new OfficeComputerBuilder();
        Manager officeManager = new Manager(officeBuilder);
        officeManager.ConstructComputer();
        Computer officeComputer = officeManager.GetComputer();
        Console.WriteLine("Office Computer: " + officeComputer);
    }
}


Sure, here's a README.md file for your Builder Pattern project:

markdown Copy code
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

csharp
Copy code
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
csharp
Copy code
internal class GamingComputerBuilder : IBuilder
{
    private Computer computer;

    public GamingComputerBuilder()
    {
        computer = new Computer();
    }

    public void StartUpOperations()
    {
        // Initialize or reset the computer object if needed
        computer = new Computer();
    }

    public void BuildCPU()
    {
        computer.CPU = "High-end Gaming CPU";
    }

    public void BuildGPU()
    {
        computer.GPU = "High-end Gaming GPU";
    }

    public void BuildRAM()
    {
        computer.RAM = "32GB Gaming RAM";
    }

    public void BuildStorage()
    {
        computer.Storage = "1TB NVMe SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
OfficeComputerBuilder
csharp
Copy code
internal class OfficeComputerBuilder : IBuilder
{
    private Computer computer;

    public OfficeComputerBuilder()
    {
        computer = new Computer();
    }

    public void StartUpOperations()
    {
        // Initialize or reset the computer object if needed
        computer = new Computer();
    }

    public void BuildCPU()
    {
        computer.CPU = "Mid-range Office CPU";
    }

    public void BuildGPU()
    {
        computer.GPU = "Integrated GPU";
    }

    public void BuildRAM()
    {
        computer.RAM = "16GB Office RAM";
    }

    public void BuildStorage()
    {
        computer.Storage = "512GB SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
Manager
The Manager class directs the construction process using the builder interface.

csharp
Copy code
internal class Manager
{
    protected readonly IBuilder builder;

    public Manager(IBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructComputer()
    {
        builder.StartUpOperations();
        builder.BuildCPU();
        builder.BuildGPU();
        builder.BuildRAM();
        builder.BuildStorage();
    }

    public Computer GetComputer()
    {
        return builder.GetComputer();
    }
}
Usage Example
Here is an example of how to use the Builder Pattern to construct different types of computers.

csharp
Copy code
class Program
{
    static void Main(string[] args)
    {
        // Constructing a gaming computer
        IBuilder gamingBuilder = new GamingComputerBuilder();
        Manager gamingManager = new Manager(gamingBuilder);
        gamingManager.ConstructComputer();
        Computer gamingComputer = gamingManager.GetComputer();
        Console.WriteLine("Gaming Computer: " + gamingComputer);

        // Constructing an office computer
        IBuilder officeBuilder = new OfficeComputerBuilder();
        Manager officeManager = new Manager(officeBuilder);
        officeManager.ConstructComputer();
        Computer officeComputer = officeManager.GetComputer();
        Console.WriteLine("Office Computer: " + officeComputer);
    }
}
Running the Example
To run the example:

Clone the repository.
Open the solution in Visual Studio or your preferred C# IDE.
Build and run the project to see the output for different types of Computer objects.
