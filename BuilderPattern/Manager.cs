

namespace BuilderPattern;

internal class Manager
{
    protected readonly IBuilder builder;

    public Manager(IBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructComputer()
    {
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
