using System.Net.NetworkInformation;
using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;

public class CategoryDtoFactory : DtoFactoryBase<Category, CategoryReadDto, CategoryCreateDto, CategoryUpdateDto>
{
    public override Category CreateEntity(CategoryCreateDto dto)
    {
        return new Category(dto.Name, dto.Description);
    }

    public override CategoryReadDto CreateRead(Category entity)
    {
        return new CategoryReadDto
        {
            Name = entity.Name
        };
    }

    public override Category UpdateEntity(Category entity, CategoryUpdateDto dto)
    {
        if (!string.IsNullOrWhiteSpace(dto.Name))
            entity.Name = dto.Name;
        if (!string.IsNullOrWhiteSpace(dto.Description))
            entity.Description = dto.Description;

        return entity;
    }
}
