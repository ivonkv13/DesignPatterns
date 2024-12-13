namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Composes objects into tree structures, allowing uniform treatment of individual objects and composites.

            //Real-life analogy: A "folder structure" containing files and subfolders.

            Folder root = new Folder("Root");
            root.Add(new File("File1.txt"));
            root.Add(new File("File2.txt"));

            Folder subFolder = new Folder("SubFolder");
            subFolder.Add(new File("File3.txt"));

            root.Add(subFolder);

            root.Display(1);
            // Output:
            // -Root
            // ---File1.txt
            // ---File2.txt
            // ---SubFolder
            // -----File3.txt
        }
    }
}
