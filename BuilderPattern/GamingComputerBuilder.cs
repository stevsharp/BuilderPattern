

namespace BuilderPattern
{
    internal class GamingComputerBuilder : IBuilder
    {
        private Computer computer;

        public GamingComputerBuilder()
        {
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

        public void InstallOperatingSystem()
        {
            computer.OS = "Linux";
        }
        public Computer GetComputer()
        {
            return computer;
        }


    }
}
