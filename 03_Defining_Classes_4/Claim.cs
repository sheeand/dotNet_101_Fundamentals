using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_4
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal ClaimAmount { get; set; }

        public Claim(int claimId, DateTime entryDate, decimal claimAmount)
        {
            ClaimId = claimId;
            EntryDate = entryDate;
            ClaimAmount = claimAmount;
        }
    }
}
