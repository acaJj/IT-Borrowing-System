using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffreyJacaEnterpriseAssignment1.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public EquipmentType Type { get; set; }

        public string Description { get; set; }
        public bool Availability { get; set; }
    }
}
