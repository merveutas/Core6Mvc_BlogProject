using Blog.Data.Context;
using Blog.Data.Repositories.Abstracts;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Blog.Service.Services.Abstracts;
using Blog.Service.Services.Concrate;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Extentions
{
    public static class ServiceLayerExtentions
    {
        public static IServiceCollection LoadServiceLayerExtention(this IServiceCollection services)
        {
            services.AddScoped<IArticleService,ArticleService>();
            return services;
        }
    }
}
