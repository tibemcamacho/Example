using Microsoft.EntityFrameworkCore;
using OnlineStore.BussinessLayer.Services.Interfaces;
using OnlineStore.DataAccessLayer.Repository.Interfaces;
using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BussinessLayer.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        private ICatalogRepository _ICatalogRepository;
        public CatalogService(ICatalogRepository CatalogRepository)
        {
            _ICatalogRepository = CatalogRepository;
        }

        public async Task<List<Article>> GetArticleHome() => await _ICatalogRepository.GetArticleHome();

        public async Task<List<Article>> GetArticle() => await _ICatalogRepository.GetArticle();

        public async Task<Article> GetArticleById(int id) => await _ICatalogRepository.GetArticleById(id);

        public async Task SaveArticle(int id) => await _ICatalogRepository.SaveArticle(id);
    }
}
