namespace Builder.Products
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }

        public void DisplayDetails() =>
            Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, GPU: {GPU}");
    }

}
