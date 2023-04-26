using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BussinessLayer.Services.Interfaces
{
    public interface ICatalogService
    {
        Task<List<Article>> GetArticleHome();

        Task<List<Article>> GetArticle();

        Task<Article> GetArticleById(int id);

        Task SaveArticle(int id);
    }
}
