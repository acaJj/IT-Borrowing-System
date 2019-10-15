using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffreyJacaEnterpriseAssignment1.Models
{
    public static class RequestRepository
    {
        public static IEnumerable<Request> Requests { get; } = new List<Request>();
        public static void AddRequest(Request r)
        {
            Requests.Append(r);
        }
    }
}
