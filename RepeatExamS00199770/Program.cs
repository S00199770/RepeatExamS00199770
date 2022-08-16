using System;
using RepeatExamS00199770;
namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipmentData db = new EquipmentData();

            using (db)
            {
                Equipment e1 = new Equipment()
                {
                    ID = 1,
                    Name = "Hedge Trimmer",
                    Description = "Light weight and highly maneuverable. This cordless model uses a long cutting length and rotatable handle.  Trim to perfection with comfort and accuracy.Get that perfectly clean cut at first pass and in comfort thanks to blades sharpened at 3 edges and a rotatable handle.",
                    Price = 300m,
                    Equipment.FuelType = Equipment.FuelType.Petrol;
                };

                Equipment e2 = new Equipment()
                {
                    ID = 2,
                    Name = "Lawn Mower",
                    Description = "Lawnmower - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam quis cursus nunc. Vivamus pretium suscipit justo, quis elementum tellus ullamcorper sed. Nullam leo mauris, congue vitae lacinia id, dictum sed velit. Praesent viverra vulputate erat. Vivamus ut justo tempor, accumsan turpis at, fringilla urna. Vestibulum vel rhoncus neque, sed mattis. ",
                    Price = 500m,
                    TypeOfFuel = FuelType.Gas
                };

                Equipment e3 = new Equipment()
                {
                    ID = 3,
                    Name = "Leaf Blower ",
                    Description = "Leaf Blower - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam quis cursus nunc. Vivamus pretium suscipit justo, quis elementum tellus ullamcorper sed. Nullam leo mauris, congue vitae lacinia id, dictum sed velit. Praesent viverra vulputate erat. Vivamus ut justo tempor, accumsan turpis at, fringilla urna. Vestibulum vel rhoncus neque, sed mattis. ",
                    Price = 170m,
                    TypeOfFuel = FuelType.Battery
                };

                Equipment e4 = new Equipment()
                {
                    ID = 4,
                    Name = "Grass Strimmer",
                    Description = "Grass Strimmer - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam quis cursus nunc. Vivamus pretium suscipit justo, quis elementum tellus ullamcorper sed. Nullam leo mauris, congue vitae lacinia id, dictum sed velit. Praesent viverra vulputate erat. Vivamus ut justo tempor, accumsan turpis at, fringilla urna. Vestibulum vel rhoncus neque, sed mattis. ",
                    Price = 200m,
                    TypeOfFuel = FuelType.Gas
                };

                Equipment e5 = new Equipment()
                {
                    ID = 5,
                    Name = "Lawn Mower",
                    Description = "Lawn Mower - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam quis cursus nunc. Vivamus pretium suscipit justo, quis elementum tellus ullamcorper sed. Nullam leo mauris, congue vitae lacinia id, dictum sed velit. Praesent viverra vulputate erat. Vivamus ut justo tempor, accumsan turpis at, fringilla urna. Vestibulum vel rhoncus neque, sed mattis. ",
                    Price = 200m,
                    TypeOfFuel = FuelType.Electric
                };

                Equipment e6 = new Equipment()
                {
                    ID = 1,
                    Name = "Chainsaw",
                    Description = "Chainsaw - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam quis cursus nunc. Vivamus pretium suscipit justo, quis elementum tellus ullamcorper sed. Nullam leo mauris, congue vitae lacinia id, dictum sed velit. Praesent viverra vulputate erat. Vivamus ut justo tempor, accumsan turpis at, fringilla urna. Vestibulum vel rhoncus neque, sed mattis. ",
                    Price = 250m,
                    TypeOfFuel = FuelType.Gas
                };
            }
        }
    }
}
