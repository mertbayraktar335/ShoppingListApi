using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Moq;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsRemove;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace ShoppingList.Handler.Test.CommandHandlers
{
    public  class ShopListRemoveCommandHandlerTest
    {
        [Fact]
        public async void RemoveShopListSuccess()
        {
            var addProductCommandRequest = new Faker<ShopListsRemoveCommandRequest>();


            var mockRepository = new Mock<IListsWriteRepository>();
            var mockRepo = new Mock<IListsReadRepository>();
            
            mockRepository.Setup(x => x.Removee(It.IsAny<ShoppList>())).Returns(true);




            var commandRequest = new ShopListsRemoveCommandHandler(mockRepository.Object,mockRepo.Object);


            var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

            Assert.NotNull(response);
        }
        [Fact]
        public async void RemoveShopListFailure()
        {
            var addProductCommandRequest = new Faker<ShopListsRemoveCommandRequest>();


            var mockRepository = new Mock<IListsWriteRepository>();
            var mockRepo = new Mock<IListsReadRepository>();

            mockRepository.Setup(x => x.Removee(It.IsAny<ShoppList>())).Returns(false);




            var commandRequest = new ShopListsRemoveCommandHandler(mockRepository.Object, mockRepo.Object);


            var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

            Assert.NotNull(response);
        }

    }
}
