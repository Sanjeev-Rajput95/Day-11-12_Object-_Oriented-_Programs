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

            var inventoryData = JsonConvert.DeserializeObject<InventoryModel>(jsonData);

            Console.WriteLine(
            inventoryData.Wheats.Name
            + inventoryData.Wheats.PricePerKg
            + inventoryData.Wheats.Weight
            +"\n"+
            inventoryData.Pulses.Name
            + inventoryData.Pulses.PricePerKg
            + inventoryData.Pulses.Weight
            +"\n"+
            inventoryData.Rice.Name
            + inventoryData.Rice.PricePerKg
            + inventoryData.Rice.Weight );


            Console.WriteLine("Data" + jsonData);

        }
    }
}
