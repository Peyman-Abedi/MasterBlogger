﻿using System.Collections.Generic;
using MB.ApplicationContract.Article;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleAgg.Services;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleValidatorServices _articleValidatorServices;

        public ArticleApplication(IArticleRepository articleRepository, IArticleValidatorServices articleValidatorServices)
        {
            _articleRepository = articleRepository;
            _articleValidatorServices = articleValidatorServices;
        }

        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Content, command.Image,
                command.ArticleCategoryId,_articleValidatorServices);
            _articleRepository.CreateAndSave(article);
        }

        public void Edit(EditArticle command)
        {
            var article = _articleRepository.Get(command.Id);
            article.Edit(command.Title,command.ShortDescription,command.Content, command.Image,command.ArticleCategoryId);
            _articleRepository.Save();
        }

        public EditArticle Get(long id)
        {
            var article = _articleRepository.Get(id);
            return new EditArticle
            {
                Id = article.Id,
                Title = article.Title,
                ArticleCategoryId = article.ArticleCategoryId,
                Content = article.Content,
                Image = article.Image,
                ShortDescription = article.ShortDescription
            };
        }

        public void Remove(long id)
        {
            var article = _articleRepository.Get(id);
            article.Remove();
            _articleRepository.Save();
        }

        public void Restore(long id)
        {
            var article = _articleRepository.Get(id);
            article.Restore();
            _articleRepository.Save();
        }
    }
}
