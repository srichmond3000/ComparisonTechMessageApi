using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IMessageRepository
    {
        Task<MessageEntity> CreateMessageAsync(MessageEntity message);

        Task<List<MessageEntity>> GetMessagesAsync();
    }
}
