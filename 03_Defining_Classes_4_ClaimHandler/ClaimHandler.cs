using _03_Defining_Classes_4;
using _03_Defining_Classes_4_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_4_ClaimHandler
{
    public class ClaimHandler
    {
        private ClaimsRepository _claimRepo = new ClaimsRepository();

        public void Insert(Claim claim)
        {
            _claimRepo.AddClaimToList(claim);
        }

        public bool ValidateEntryDate(Claim claim)
        {
            if (claim.EntryDate > DateTime.Now.AddDays(-30))
            {
                return true;
            }
            else
            {
                return false;
            }
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
