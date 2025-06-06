﻿using Api.Infrastructure.Entities;
using Model.DTOs.Card;

namespace Api.Shared.Extensions
{
    public static class CardExtension
    {
        public static CardEntity ToEntity(this DeckDTO dto, string newId)
        {
            return new CardEntity
            {
                Id = newId,
                CollectionId = dto.CollectionId,
                Name = dto.Name,
                Description = dto.Description,
                Number = dto.Number,
                ManaCost = dto.ManaCost,
                Label = dto.Label,
                Code = dto.Code,
                Foil = dto.Foil
            };
        }

        public static DeckResponseDTO ToResponseDTO(this CardEntity entity)
        {
            return new DeckResponseDTO
            {
                Id = entity.Id,
                CollectionId = entity.CollectionId,
                Name = entity.Name,
                Description = entity.Description,
                Number = entity.Number,
                ManaCost = entity.ManaCost,
                Label = entity.Label,
                Code = entity.Code,
                Foil = entity.Foil
            };
        }

        public static DeckResponseDTO ToResponseDTO(this DeckDTO dto, string newId)
        {
            return new DeckResponseDTO
            {
                Id = newId,
                CollectionId = dto.CollectionId,
                Name = dto.Name,
                Description = dto.Description,
                Number = dto.Number,
                ManaCost = dto.ManaCost,
                Label = dto.Label,
                Code = dto.Code,
                Foil = dto.Foil
            };
        }

        public static void UpdateFromDTO(this CardEntity entity, DeckDTO dto)
        {
            entity.CollectionId = dto.CollectionId;
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.Number = dto.Number;
            entity.ManaCost = dto.ManaCost;
            entity.Label = dto.Label;
            entity.Code = dto.Code;
            entity.Foil = dto.Foil;
        }
    }
}
