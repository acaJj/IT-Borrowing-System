using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffreyJacaEnterpriseAssignment1.Models
{
    public static class RequestRepository
    {
        private static List<Request> requests = new List<Request>();
        public static int requestCounter = 0;
        public static void AddRequest(Request r)
        {
            r.Id = requestCounter;
            requests.Add(r);
            requestCounter++;
        }

        public static IEnumerable<Request> Requests
        {
            get
            {
                return requests;
            }
        }

        public static IEnumerable<Request> GetSampleRequesets()
        {

            return new List<Request>()
            {
                new Request()
            {
                Id = 0,
                Name = "request 1",
                Email = "abc@mail.com",
                PhoneNumber = "1111111111",
                Role = "Student",
                EquipmentType = EquipmentType.Laptop,
                Details = "details 1",
                Duration = 1

            },

            new Request()
            {
                Id = 1,
                Name = "request 2",
                Email = "def@mail.com",
                PhoneNumber = "2222222222",
                Role = "Professor",
                EquipmentType = EquipmentType.Phone,
                Details = "details 2",
                Duration = 2

            },

            new Request()
            {
                Id = 2,
                Name = "request 3",
                Email = "ghi@mail.com",
                PhoneNumber = "1111111111",
                Role = "Student",
                EquipmentType = EquipmentType.Tablet,
                Details = "details 3",
                Duration = 3

            }
            };

        }
    }
}
