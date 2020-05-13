using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HannahByrne_S00189764;

namespace DataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                //Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                //Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");

                Phone p1 = new Phone() { Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg" };
                Phone p2 = new Phone() { Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iphone11.jpg" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added Phones to Database");

                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            }
        }
    }
}
