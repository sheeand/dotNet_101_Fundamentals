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
        private List<Claim> ClaimsList = new List<Claim>();

        public void AddClaimToList(Claim claim)
        {
            ClaimsList.Add(claim);
        }

        public List<Claim> GetClaimsList()
        {
            return ClaimsList;
        }
    }
}
