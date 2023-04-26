using Microsoft.AspNetCore.Mvc;
using OnlineStore.BussinessLayer.Services.Interfaces;
using OnlineStore_Models;
using System.Net;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _IContactService;
        private readonly ILogger<ContactController> _logger;
        public ContactController(ILogger<ContactController> logger, IContactService IContactService)
        {
            _logger = logger;
            _IContactService = IContactService;
        }

        [Route("SaveContact")]
        [HttpPost]
        public async Task<IActionResult> SaveContact(Contact contact)
        {
            try
            {
                await _IContactService.SaveContact(contact);
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
