using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonTechMessageApi.Mappings;
using ComparisonTechMessageApi.ViewModels;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComparisonTechMessageApi.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        private IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var messages = await _messageService.GetMessagesAsync();

            return Ok(messages.Select(m => m.MapToViewModel()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(MessageViewModel viewModel)
        {
            var created = await _messageService.CreateMessageAsync(viewModel.MapToEntity());

            return Ok(created.MapToViewModel());
        }
    }
}
