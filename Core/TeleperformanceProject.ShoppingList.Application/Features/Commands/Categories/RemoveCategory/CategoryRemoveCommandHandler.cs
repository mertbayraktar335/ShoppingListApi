using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.Repositories.Categories;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Categories.RemoveCategory
{
    public class CategoryRemoveCommandHandler : IRequestHandler<CategoryRemoveCommandRequest, CategoryRemoveCommandResponse>
    {
        private readonly ICategoryReadRepository _read;
        private readonly ICategoryWriteRepository _repo;
        private readonly IMapper _mapper;

        public CategoryRemoveCommandHandler(ICategoryReadRepository read, ICategoryWriteRepository repo, IMapper mapper)
        {
            _read = read;
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<CategoryRemoveCommandResponse> Handle(CategoryRemoveCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await _read.GetByIdAsync(request.Id);
            _repo.Removee(category);
            _repo.SaveAsync();
            return new()
            {

            };

        }
    }
}
