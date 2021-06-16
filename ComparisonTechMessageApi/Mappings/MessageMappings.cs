using System;
using ComparisonTechMessageApi.ViewModels;
using Core.Entities;

namespace ComparisonTechMessageApi.Mappings
{
    public static class MessageMappings
    {
        public static MessageViewModel MapToViewModel(this MessageEntity message)
        {
            return new MessageViewModel
            {
                Id = message.Id,
                Message = message.Message
            };
        }

        public static MessageEntity MapToEntity(this MessageViewModel message)
        {
            return new MessageEntity
            {
                Id = message.Id,
                Message = message.Message
            };
        }
    }
}
