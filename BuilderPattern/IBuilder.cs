

namespace BuilderPattern
{
    public interface IBuilder
    {
        void BuildCPU();
        void BuildGPU();
        void BuildRAM();
        void BuildStorage();
        void InstallOperatingSystem();
        Computer GetComputer();


    }
}
