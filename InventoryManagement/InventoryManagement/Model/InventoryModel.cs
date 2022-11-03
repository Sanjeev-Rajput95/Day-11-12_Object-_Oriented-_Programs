using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class InventoryModel
    {
        public List< CommanProperties >Rice { get; set; }
        public List<CommanProperties> Pulses { get; set; }
        public List<CommanProperties> Wheats { get; set; }

    }

    public class CommanProperties
    {
        public string Name { get; set; }
        public int  Weight { get; set; }
        public int PricePerKg { get; set; }

    }
}
