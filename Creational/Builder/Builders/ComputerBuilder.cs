using Builder.Products;

namespace Builder.Builders
{
    public class ComputerBuilder
    {
        private Computer computer = new Computer();

        public ComputerBuilder SetCPU(string cpu) { computer.CPU = cpu; return this; }
        public ComputerBuilder SetRAM(string ram) { computer.RAM = ram; return this; }
        public ComputerBuilder SetGPU(string gpu) { computer.GPU = gpu; return this; }

        public Computer Build() => computer;
    }

}
