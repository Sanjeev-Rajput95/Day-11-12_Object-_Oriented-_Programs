namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Object Oriented Program !");

            InvetoryManager invetoryManager = new InvetoryManager();
            invetoryManager.CalculateInventoryValue();
        }
    }
}