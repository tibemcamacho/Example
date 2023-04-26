
using Microsoft.AspNetCore.Mvc;
using OnlineStore.BussinessLayer.Services.Interfaces;
using System.Net;
//using OnlineStore.BussinessLayer.Services.Interfaces;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController :  ControllerBase
    {
        private readonly ICatalogService _ICatalogService;
        private readonly ILogger<CatalogController> _logger;
        public CatalogController(ILogger<CatalogController> logger, ICatalogService ICatalogService)
        {
            _logger = logger;
            _ICatalogService = ICatalogService;
        }

        [Route("GetArticleHome")]
        [HttpGet]
        public async Task<IActionResult> GetArticleHome()
        {
            try
            {
                return Ok(await _ICatalogService.GetArticleHome());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("GetArticle")]
        [HttpGet]
        public async Task<IActionResult> GetArticle()
        {
            try
            {
                return Ok(await _ICatalogService.GetArticle());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("GetArticleById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetArticleById(int id)
        {
            try
            {
                return Ok(await _ICatalogService.GetArticleById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("SaveArticle/{id}")]
        [HttpGet]
        public async Task<IActionResult> SaveArticle(int id)
        {
            try
            {
                await _ICatalogService.SaveArticle(id);
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}