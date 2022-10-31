using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class InventoryModel
    {
        public CommanProperties Rice { get; set; }
        public CommanProperties Pulses { get; set; }
        public CommanProperties Wheats { get; set; }

    }

    public class CommanProperties
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string PricePerKg { get; set; }

    }
}
