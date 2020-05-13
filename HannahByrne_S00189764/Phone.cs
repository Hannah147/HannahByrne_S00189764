using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HannahByrne_S00189764
{
    public class Phone
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public double IncreasePrice(double percentage)
        {
            Price = Price + (Price * percentage);
            return Price;
        }
    }

    
}
