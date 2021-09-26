﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MB.ApplicationContract.Article;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public List<ArticleViewModel> GetList()
        {
            return _context.Articles.Include(c => c.ArticleCategory).Select(c=> new ArticleViewModel
            {
                Id = c.Id,
                Title = c.Title,
                ArticleCategory = c.ArticleCategory.Title,
                IsRemoved = c.IsRemoved,
                CreationDate = c.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).AsNoTracking().ToList();
        }

        public void CreateAndSave(Article entity)
        {
            _context.Articles.Add(entity);
            Save();
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
