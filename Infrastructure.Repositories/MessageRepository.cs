using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Repositories
{
    // Using hard coded data. Normally this would be database access.
    public class MessageRepository : IMessageRepository
    {
        private List<MessageEntity> _messages;

        public MessageRepository()
        {
            InitialiseMessages();
        }

        public async Task<MessageEntity> CreateMessageAsync(MessageEntity message)
        {
            message.Id = _messages.Select(m => m.Id).Max() + 1;
            _messages.Add(message);

            return await Task.Run(() => message);
        }

        public async Task<List<MessageEntity>> GetMessagesAsync()
        {
            return await Task.Run(() => _messages);
        }

        private void InitialiseMessages()
        {
            _messages = new List<MessageEntity>
            {
                new MessageEntity
                {
                    Id = 1,
                    Message = "Message one"
                },
                new MessageEntity
                {
                    Id = 2,
                    Message = "Message two"
                }
            };
        }
    }
}
