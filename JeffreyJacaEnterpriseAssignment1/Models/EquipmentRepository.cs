using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffreyJacaEnterpriseAssignment1.Models
{
    public class EquipmentRepository
    {
        public static IEnumerable<Equipment> Equipment = new List<Equipment>();
        public static IEnumerable<Equipment> GetInitialEquipment()
        {
            return new List<Equipment>()
            {
                new Equipment()
                {
                    Id = 0,
                    Type = EquipmentType.Laptop,
                    Description = "Dell Inspiron",
                    Availability = true
                },
                new Equipment()
                {
                    Id = 1,
                    Type = EquipmentType.Phone,
                    Description = "Samsung Galaxy S7",
                    Availability = true
                },
                new Equipment()
                {
                    Id = 2,
                    Type = EquipmentType.Tablet,
                    Description = "IPad 54",
                    Availability = false
                },
                new Equipment()
                {
                    Id = 3,
                    Type = EquipmentType.Another,
                    Description = "laser gun",
                    Availability = false
                },
            };
        }
    }
}
