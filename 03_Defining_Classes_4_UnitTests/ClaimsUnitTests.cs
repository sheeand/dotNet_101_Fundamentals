using System;
using System.Collections.Generic;
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
        private Queue<Call> _callsList;
        private Call _testCall1;
        private Call _testCall2;
        private Call _testCall3;

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

            _testCall1 = new Call(0, DateTime.Now, "");
            _testCall2 = new Call(1, DateTime.Now, "");
            _testCall3 = new Call(2, DateTime.Now, "");

            _callsList = new Queue<Call>();
            _callsList.Enqueue(_testCall1);
            _callsList.Enqueue(_testCall2);
            _callsList.Enqueue(_testCall3);
        }

        [TestMethod]
        public void ClaimWithinTimeframe_IsValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[0];

            ClaimsRepository handler = new ClaimsRepository();
            Assert.IsTrue(handler.IsValidEntryDate(claim));
        }

        [TestMethod]
        public void ClaimOutsideOfTimeframe_IsNotValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[1];

            ClaimsRepository handler = new ClaimsRepository();
            Assert.IsFalse(handler.IsValidEntryDate(claim));
        }

        [TestMethod]
        public void ClaimUnderTenThousand_IsValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[0];

            ClaimsRepository handler = new ClaimsRepository();
            Assert.AreEqual("Your claim is being processed.", handler.ValidateAmount(claim));
        }

        [TestMethod]
        public void ClaimOverTenThousand_IsNotValid()
        {
            List<Claim> claims = _claimRepo.GetClaimsList();
            Claim claim = claims[2];

            ClaimsRepository handler = new ClaimsRepository();
            Assert.AreEqual("Please call your agent, now.", handler.ValidateAmount(claim));
        }

        [TestMethod]
        public void ReceivedCall_IsAddedToQueue()
        {

            ClaimsRepository handler = new ClaimsRepository();
            var receivedCall = handler.ViewNextCall(_callsList);

            Assert.AreEqual(receivedCall.CallId, _testCall1.CallId);
        }

        [TestMethod]
        public void TakenCall_IsDroppedFromQueue()
        {
            ClaimsRepository handler = new ClaimsRepository();
            var takenCall = handler.TakeNextCall(_callsList);
            Assert.AreEqual(takenCall.CallId, _testCall1.CallId);

            var nextCall = handler.ViewNextCall(_callsList);
            Assert.AreEqual(nextCall.CallId, _testCall2.CallId);
        }

    }
}
