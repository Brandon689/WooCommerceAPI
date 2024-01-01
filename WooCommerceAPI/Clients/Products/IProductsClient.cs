﻿using WooCommerceAPI.Models.Services.Foundations.Products;
using WooCommerceAPI.Models.Services.Foundations.ProductVariations;

namespace WooCommerceAPI.Clients.Products
{
    public interface IProductsClient
    {
        ValueTask<Product> SendProductAsync(Product product);
        ValueTask<ProductVariations> SendProductVariationsAsync(ProductVariations product);
    }
}
