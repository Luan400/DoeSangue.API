using DoeSangue.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.UnitTests.Core.Entities
{
    public class DonationTest
    {
        [Fact]

        public void TestIfDonationWork()
        {
            var donation = new Donation(5, 12);

            Assert.NotNull(donation);

            donation.Update(10);

            Assert.Equal(460, donation.QuantidadeML);
        }
    }
}
