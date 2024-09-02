using Azure.Core;
using DoeSangue.Applications.Command.CreateDonation;
using DoeSangue.Core.Entities;
using DoeSangue.Domain.Repositories;
using DoeSangue.Infrastructure.Persistence;
using Moq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.UnitTests.Application
{
    public class CreateDonationCommandHandlerTests
    {
        [Fact]

        public async Task TestIfDonationCreateWork() {


            var unitOfWork = new Mock<IUnitOfWork>();

            var donationRepository = new Mock<IDonationRepository>();

            var createDonateCommand = new CreateDonationCommand { DonorId = 5, QuantidadeML = 10 };

            var createDonationCommandHandler = new CreateDonationCommandHandler(UnitOfWork.Object);

            var id = await createDonationCommandHandler.Handle(createDonateCommand, new CancellationToken());     

            Assert.True(id >= 0);

            donationRepository.Verify(pr => pr.AddAsync(It.IsAny<Donation>() ), Times.Once );

        }
    }
}
