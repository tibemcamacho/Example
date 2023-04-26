using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.BussinessLayer.Services.Implementations;
using OnlineStore.BussinessLayer.Services.Interfaces;
using OnlineStore.Common.DTOs;
using OnlineStore_Models;
using System.Net;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _IUserService;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IUserService IUserService)
        {
            _logger = logger;
            _IUserService = IUserService;
        }

        [Route("SaveUser")]
        [HttpPost]
        public async Task<IActionResult> SaveUser(CustomerDTO customerDTO)
        {
            try
            {
                if (await _IUserService.UserValid(customerDTO.Email))
                {
                    Customer customer = JsonConvert.DeserializeObject<Customer>(JsonConvert.SerializeObject(customerDTO));
                    await _IUserService.SaveUser(customer);
                    return Ok(HttpStatusCode.OK);
                }else
                    return NotFound("El usuario ya se encuentra registrado");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("GetUser/{email}/{password}")]
        [HttpGet]
        public async Task<IActionResult> GetUser(string email, string password)
        {
            try
            {
                return Ok(await _IUserService.GetUser(email, password));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
