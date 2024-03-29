﻿using Microsoft.EntityFrameworkCore;
using P335_BackEnd.Data;
using P335_BackEnd.Entities;

namespace P335_BackEnd.Services
{
    public class ProductService
    {
        private readonly AppDbContext _dbContext;

        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetFeaturedProducts(int? categoryId)
        {
            return _dbContext.ProductTypesProducts
                .Include(x => x.ProductType)
                .Include(x => x.Product)
                .ThenInclude(p => p.ProductImages)
                .ThenInclude(pi => pi.Image)       
                .Where(x => x.ProductType.Name == "Featured" && (categoryId == null ? true : x.Product.CategoryId == categoryId))
                .Select(x => x.Product)
                .ToList();
        }


        public List<Product> GetLatestProducts()
        {
            return _dbContext.ProductTypesProducts
                    .Include(x => x.ProductType)
                    .Include(x => x.Product)
                    .ThenInclude(p => p.ProductImages)
                    .ThenInclude(pi => pi.Image)
                    .Where(x => x.ProductType.Name == "Latest")
                    .Select(x => x.Product)
                    .ToList();
        }

        public List<Product> GetTopRatedProducts()
        {
            return _dbContext.ProductTypesProducts
                    .Include(x => x.ProductType)
                    .Include(x => x.Product)
                    .ThenInclude(p => p.ProductImages)
                    .ThenInclude(pi => pi.Image)
                    .Where(x => x.ProductType.Name == "Top Rated")
                    .Select(x => x.Product)
                    .ToList();
        }

        public List<Product> GetReviewProducts()
        {
            return _dbContext.ProductTypesProducts
                    .Include(x => x.ProductType)
                    .Include(x => x.Product)
                    .ThenInclude(p => p.ProductImages)
                    .ThenInclude(pi => pi.Image)
                    .Where(x => x.ProductType.Name == "Review")
                    .Select(x => x.Product)
                    .ToList();
        }
    }
}
