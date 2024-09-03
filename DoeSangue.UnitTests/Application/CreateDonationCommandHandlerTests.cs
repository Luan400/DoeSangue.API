using DoeSangue.Applications.Command.CreateDonation;
using DoeSangue.Core.Entities;
using DoeSangue.Domain.Repositories;
using DoeSangue.Infrastructure.Persistence;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DoeSangue.UnitTests.Application
{
    public class CreateDonationCommandHandlerTests
    {
        [Fact]
        public async Task TestIfDonationCreateWork()
        {
            // Arrange
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            var donationRepositoryMock = new Mock<IDonationRepository>();

            // Configura o mock para retornar o mock do repositório de doações
            unitOfWorkMock.Setup(uow => uow.DonationRepository).Returns(donationRepositoryMock.Object);

            // Cria uma instância do comando com os parâmetros necessários
            var createDonateCommand = new CreateDonationCommand(donorId: 5, quantidadeML: 10);

            // Cria a instância do handler com o mock do IUnitOfWork
            var createDonationCommandHandler = new CreateDonationCommandHandler(unitOfWorkMock.Object);

            // Act
            var id = await createDonationCommandHandler.Handle(createDonateCommand, new CancellationToken());

            // Assert
            Assert.True(id >= 0);

            // Verifica se o método AddAsync foi chamado exatamente uma vez
            donationRepositoryMock.Verify(pr => pr.AddAsync(It.IsAny<Donation>()), Times.Once);
        }
    }
}
