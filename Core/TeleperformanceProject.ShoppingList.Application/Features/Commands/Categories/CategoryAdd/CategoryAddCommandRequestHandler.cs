using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.Repositories.Categories;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Categories.CategoryAdd
{
    public class CategoryAddCommandRequestHandler : IRequestHandler<CategoryAddCommandRequest, CategoryAddCommandResponse>
    {
        private readonly ICategoryReadRepository _read;
        private readonly ICategoryWriteRepository _repo;
        private readonly IMapper _mapper;

        public CategoryAddCommandRequestHandler(ICategoryReadRepository read, ICategoryWriteRepository repo, IMapper mapper)
        {
            _read = read;
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<CategoryAddCommandResponse> Handle(CategoryAddCommandRequest request, CancellationToken cancellationToken)
        {
            await _repo.AddAsync(new()
            {
                Name=request.CategoryName,
                Description=request.CategoryDescription
            });

            _repo.SaveAsync();
            return new()
            {
               

            };
        }
    }
}
