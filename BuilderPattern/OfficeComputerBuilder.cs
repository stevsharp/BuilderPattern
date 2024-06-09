

namespace BuilderPattern
{
    internal class OfficeComputerBuilder : IBuilder
    {
        private Computer computer;

        public OfficeComputerBuilder()
        {
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

        public void InstallOperatingSystem()
        {
            computer.OS = "Windows";
        }

        public Computer GetComputer()
        {
            return computer;
        }


    }
}