using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffreyJacaEnterpriseAssignment1.Models
{
    public static class RequestRepository
    {
        public static IEnumerable<Request> Requests = new List<Request>();
        public static int requestCounter = 0;
        public static void AddRequest(Request r)
        {
            r.Id = requestCounter;
            Requests.Append(r);
            requestCounter++;
        }

        public static IEnumerable<Request> GetRequests()
        {
            return Requests;
        }
    }
}
