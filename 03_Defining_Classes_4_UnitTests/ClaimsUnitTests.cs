using System;
using System.Collections.Generic;
using _03_Defining_Classes_4_ClaimHandler;
using _03_Defining_Classes_4_Repository;
using _03_Defining_Classes_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_4_UnitTests
{
    [TestClass]
    public class ClaimsUnitTests
    {

        private ClaimsRepository _claimRepo;
        private Claim _claim;

        [TestInitialize]
        public void Arrange()
        {
            _claimRepo = new ClaimsRepository();
            _claim = new Claim(101, DateTime.Now.AddDays(-10), 5000.0m);
            _claimRepo.AddClaimToList(_claim);

            _claim = new Claim(102, DateTime.Now.AddDays(-40), 5000.0m);
            _claimRepo.AddClaimToList(_claim);

            _claim = new Claim(101, DateTime.Now.AddDays(-10), 50000.0m);
            _claimRepo.AddClaimToList(_claim);

        }

        [TestMethod]
        public void ClaimWithinTimeframe_IsValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[0];

            ClaimHandler handler = new ClaimHandler();
            Assert.IsTrue(handler.ValidateEntryDate(claim));


        }

        [TestMethod]
        public void ClaimOutsideOfTimeframe_IsNotValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[1];

            ClaimHandler handler = new ClaimHandler();
            Assert.IsFalse(handler.ValidateEntryDate(claim));
        }

        [TestMethod]
        public void ClaimUnderTenThousand_IsValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[0];

            ClaimHandler handler = new ClaimHandler();
            Assert.AreEqual("Your claim is being processed.", handler.ValidateAmount(claim));
        }

        [TestMethod]
        public void ClaimOverTenThousand_IsNotValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[2];

            ClaimHandler handler = new ClaimHandler();
            Assert.AreEqual("Please call your agent, now.", handler.ValidateAmount(claim));
        }
    }
}
