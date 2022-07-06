using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Moq;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.RemoveProduct;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace ShoppingList.Handler.Test.CommandHandlers
{
    public class RemoveProductCommandHandlerTest
    {
        [Fact]
        public async void RemoveProductSuccess()
        {
            var addProductCommandRequest = new Faker<RemoveProductsCommandRequest>();

            var mockRepo = new Mock<IProductReadRepository>();
            var mockRepository = new Mock<IProductWriteRepository>();
            mockRepository.Setup(x => x.Removee(It.IsAny<Product>())).Returns(true);




            var commandRequest = new RemoveProductsCommandHandler(mockRepository.Object,mockRepo.Object);


            var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

            Assert.NotNull(response);
        }
        [Fact]
        public async void RemoveProductFailure()
        {
            var addProductCommandRequest = new Faker<RemoveProductsCommandRequest>();
            var mockRepo = new Mock<IProductReadRepository>();

            var mockRepository = new Mock<IProductWriteRepository>();
            mockRepository.Setup(x => x.AddAsync(It.IsAny<Product>())).ReturnsAsync(false);


            var commandRequest = new RemoveProductsCommandHandler(mockRepository.Object,mockRepo.Object);


            var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

            Assert.NotNull(response);
        }
    }
}
