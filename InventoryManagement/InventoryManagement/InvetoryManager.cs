using InventoryManagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InvetoryManager
    {
        public string FilePath = @"C:\\Bridgelabz\\Day11&12ObjectOrientedPrograms\\Day-11-12_Object-_Oriented-_Programs\\InventoryManagement\\InventoryManagement\\JsonFile\\InventoryData.json";

        public void CalculateInventoryValue()
        {
            var jsonData = File.ReadAllText(FilePath);

            var inventoryData = JsonConvert.DeserializeObject<InventoryModel>(jsonData);    //list

            foreach(var Wheats in inventoryData.Wheats)
            {
                Console.WriteLine(Wheats.Name + "\n" + Wheats.Weight + "\n" + Wheats.PricePerKg);
                Console.WriteLine($"Total Price of {Wheats.Name} is :  Rs. {Wheats.PricePerKg * Wheats.Weight}");
            }

            foreach(var Pulses in inventoryData.Pulses)
            {
                Console.WriteLine(Pulses.Name + "\n" + Pulses.Weight + "\n" + Pulses.PricePerKg);
                Console.WriteLine($"Total Price of {Pulses.Name} is : Rs. {Pulses.PricePerKg * Pulses.Weight}");
            }

            foreach (var Rice in inventoryData.Rice)
            {
                Console.WriteLine(Rice.Name + "\n" + Rice.Weight + "\n" + Rice.PricePerKg);
                Console.WriteLine($"Total Price of {Rice.Name} is : Rs. {Rice.PricePerKg * Rice.Weight}");
            }

            Console.WriteLine("Data" + jsonData);

        }
    }
}
