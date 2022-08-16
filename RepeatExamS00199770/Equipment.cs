using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace RepeatExamS00199770
{
    class Equipment
    {
        public int ID;
        public enum FuelType { Electrical, Battery, Petrol }
        public string Name;
        public decimal Price;
        public string Description;
        public List<Equipment> Tools {get; set;}


        public decimal AddVat(decimal productPrice)
        {
            //we get the VAT here
            decimal getProductVat = (productPrice / 100) * 23;
            //add the vat to the items price
            decimal AfterVAT = getProductVat + getProductVat;

            return AfterVAT;
        }

        
        
    }
    public class EquipmentData:DbContext
    {
        public EquipmentData() : base("EquipmentData") { }

        public DbSet<EquipmentData> Tools{ get; set; }

    }
}
