using _03_Defining_Classes_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_4_Repository
{
    public class ClaimsRepository
    {
        public List<Claim> ClaimsList = new List<Claim>();

        public List<Claim> GetClaimsList()
        {
            return ClaimsList;
        }

        public Call ViewNextCall(Queue<Call> callList)
        {
            var call = new Call();
            if (callList.Count > 0)
            {
                call = callList.Peek();
            }
            return call;
        }

        public Call TakeNextCall(Queue<Call> callList)
        {
            var call = new Call();
            if (callList.Count > 0)
            {
                call = callList.Dequeue();
            }
            return call;
        }

        public bool IsValidEntryDate(Claim claim)
        {
            return claim.EntryDate > DateTime.Now.AddDays(-30);
        }

        public void AddClaimToList(Claim claim)
        {
            ClaimsList.Add(claim);
        }

        public string ValidateAmount(Claim claim)
        {
            string message = "";
            if (claim.ClaimAmount > 10000.0m)
            {
                return message = "Please call your agent, now.";
            }
            else
            {
                return message = "Your claim is being processed.";
            }
        }
    }
}
