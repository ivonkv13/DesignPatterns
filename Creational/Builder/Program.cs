using Builder.Builders;
using Builder.Products;

namespace Builder
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Separate construction of a complex object from its representation.

            //Real-life analogy:
            //Consider building a complex `Computer` object.


            Computer gamingPC = new ComputerBuilder()
                                .SetCPU("Intel i9")
                                .SetRAM("32GB")
                                .SetGPU("NVIDIA RTX 3090")
                                .Build();

            gamingPC.DisplayDetails();

            // Output: CPU: Intel i9, RAM: 32GB, GPU: NVIDIA RTX 3090
        }
    }
}
