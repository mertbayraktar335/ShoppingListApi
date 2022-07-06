using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Moq;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsAdd;
using TeleperformanceProject.ShoppingList.Application.Repositories;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace ShoppingList.Handler.Test.CommandHandlers
{
    [Fact]
    public async void AddShopListsSuccess()
    {
        var addProductCommandRequest = new Faker<ShopListsAddCommandRequest>();


        var mockRepository = new Mock<IListsWriteRepository>();
        var mockRepo = new Mock<IUserRepo>(It.IsAny<User>())).Returns(User);
         mockRepository.Setup(x => x.Removee(It.IsAny<ShoppList>())).Returns(true);

       var commandRequest = new ShopListsAddCommandHandler(mockRepository.Object,mockRepo.Object);


        var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

        Assert.NotNull(response);
    }
    [Fact]
    public async void AddShopListsFailure()
    {
        var addProductCommandRequest = new Faker<ShopListsAddCommandRequest>();


        var mockRepository = new Mock<IListsWriteRepository>();
        var mockRepo = new Mock<IUserRepo>(It.IsAny<User>())).Returns(User);
        mockRepository.Setup(x => x.Removee(It.IsAny<ShoppList>())).Returns(true);

        var commandRequest = new ShopListsAddCommandHandler(mockRepository.Object, mockRepo.Object);


        var response = await commandRequest.Handle(addProductCommandRequest, CancellationToken.None);

        Assert.NotNull(response);
    }





}
