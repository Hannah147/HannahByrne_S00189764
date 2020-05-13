using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HannahByrne_S00189764
{
    public class Phone
    {
        /* I kept getting an error about no key being defined, 
         * it worked when I put in [Key] but it added an extra column to the table
         * I couldn't figure out any other way around it */

        [Key]
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public virtual List<Phone> Phones { get; set; }

        public double IncreasePrice(double percentage)
        {
            Price = Price + (Price * percentage);
            return Price;
        }
    }

    public class PhoneData : DbContext
    {
        public PhoneData():base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }



}
