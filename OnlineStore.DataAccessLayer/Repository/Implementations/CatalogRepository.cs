using Microsoft.EntityFrameworkCore;
using OnlineStore.DataAccessLayer.Repository.Interfaces;
using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccessLayer.Repository.Implementations
{
    public class CatalogRepository : ICatalogRepository
    {
        private StoreDbConn _Context;
        public CatalogRepository(StoreDbConn Context)
        {
            _Context = Context;
        }

        public async Task<List<Article>> GetArticleHome() => await _Context.Article.Take(9).ToListAsync();

        public async Task<List<Article>> GetArticle() => await _Context.Article.ToListAsync();

        public async Task<Article> GetArticleById(int id) => await _Context.Article.FindAsync(id);
        public async Task SaveArticle(int id)
        {
            var art = await _Context.Article.FindAsync(id);
            art.Stock = art.Stock - 1;
            _Context.Entry(art).State = EntityState.Modified;
            await _Context.SaveChangesAsync();
        }
    }
}
