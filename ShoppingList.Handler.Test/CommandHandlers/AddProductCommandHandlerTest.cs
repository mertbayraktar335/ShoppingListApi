using Bogus;
using Moq;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.AddProduct;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace ShoppingList.Handler.Test.CommandHandlers
{
    public class AddProductCommandHandlerTest
    {
        [Fact]
        public async void AddProductSuccess()
        {
            var addProductCommandRequest = new Faker<AddProductCommandRequest>();
            

            var mockRepository = new Mock<IProductWriteRepository>();
            mockRepository.Setup(x => x.Removee(It.IsAny<Product>())).Returns(true);




            var commandRequest = new AddProductCommandHandler(mockRepository.Object);


          var response=  await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

            Assert.NotNull(response);
        }
        [Fact]
        public async void AddProductFailure()
        {
            var addProductCommandRequest = new Faker<AddProductCommandRequest>();


            var mockRepository = new Mock<IProductWriteRepository>();
            mockRepository.Setup(x => x.AddAsync(It.IsAny<Product>())).ReturnsAsync(false);


            var commandRequest = new AddProductCommandHandler(mockRepository.Object);


            var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

            Assert.NotNull(response);
        }
    }
}