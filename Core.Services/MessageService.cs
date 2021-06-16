using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
    public class MessageService : IMessageService
    {
        private IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<MessageEntity> CreateMessageAsync(MessageEntity message)
        {
            // In production this would contain business logic. If this method
            // remains just a pass through clients could consider using the
            // repository directly.
            return await _messageRepository.CreateMessageAsync(message);
        }

        public async Task<List<MessageEntity>> GetMessagesAsync()
        {
            // In production this would contain business logic. If this method
            // remains just a pass through clients could consider using the
            // repository directly.
            return await _messageRepository.GetMessagesAsync();
        }
    }
}
