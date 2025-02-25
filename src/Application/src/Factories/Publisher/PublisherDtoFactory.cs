using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;

public class PublisherDtoFactory : DtoFactoryBase<Publisher, PublisherReadDto, PublisherCreateDto, PublisherUpdateDto>
{
    public override Publisher CreateEntity(PublisherCreateDto dto)
    {
        return new Publisher(dto.Name, dto.Address, dto.ContactEmail);
    }

    public override PublisherReadDto CreateRead(Publisher entity)
    {
        return new PublisherReadDto
        {
            Id = entity.Id,
            Name = entity.Name
        };
    }

    public override Publisher UpdateEntity(Publisher entity, PublisherUpdateDto dto)
    {
        if (!string.IsNullOrWhiteSpace(dto.Name))
            entity.Name = dto.Name;
        if (!string.IsNullOrWhiteSpace(dto.Address))
            entity.Address = dto.Address;
        if (!string.IsNullOrWhiteSpace(dto.ContactEmail))
            entity.ContactEmail = dto.ContactEmail;
        
        return entity;
    }
}
