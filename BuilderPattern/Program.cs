using BuilderPattern;

try
{
    // Constructing a gaming computer
    IBuilder gamingBuilder = new GamingComputerBuilder();
    var gamingManager = new Manager(gamingBuilder);
    gamingManager.ConstructComputer();

    Computer gamingComputer = gamingManager.GetComputer();
    Console.WriteLine("Gaming Computer: " + gamingComputer);

    // Constructing an office computer
    IBuilder officeBuilder = new OfficeComputerBuilder();
    
    var officeManager = new Manager(officeBuilder);
    officeManager.ConstructComputer();


    Computer officeComputer = officeManager.GetComputer();
    Console.WriteLine("Office Computer: " + officeComputer);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();