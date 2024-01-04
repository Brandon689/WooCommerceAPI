﻿using dotenv.net;
using FacadeAPI;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WooCommerceAPI.Clients.WooCommerces;
using WooCommerceAPI.Models.Services.Foundations.Media;
using WooCommerceAPI.Models.Services.Foundations.Products;
using WooCommerceAPI.Models.Services.Foundations.ProductVariations;





ShopifyProduct sp = JsonSerializer.Deserialize<ShopifyProduct>(File.ReadAllText(@"C:\2024\1\Shopify\json_project\downloaded_data.json"));









DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { "../../../../ConsoleApp1/.env" }));

var facade = new WooCommerceFacade(
    Environment.GetEnvironmentVariable("WC_CONSUMER_KEY"),
    Environment.GetEnvironmentVariable("WC_CONSUMER_SECRET"),
    Environment.GetEnvironmentVariable("WC_STORE_URL"),
    Environment.GetEnvironmentVariable("WP_USER"),
    Environment.GetEnvironmentVariable("WP_APP_PASSWORD")
);


;


var spe = await facade.prod(sp.product);

//var result = await facade.CreateProductAsync("name", "simple", "10");
var result = await facade.CreateProductAsync(spe);





var yo = facade.hime(sp.product);
;

ProductVariations pv = new()
{
    Request = yo
};
pv.Request.ProductId = result.Response.Id;
var result2 = await facade.yy(pv);


//var attribute1 = new ProductAttributeBuilder()
//    .WithName("CCC")
//    .WithVariation(true)
//    .WithOptions("Red", "Blue")
//    .Build();

//var attribute2 = new ProductAttributeBuilder()
//    .WithName("ZZZ")
//    .WithVariation(true)
//    .WithOptions("Small", "Medium", "Large")
//    .Build();

//var product = new ProductBuilder()
//    .WithName($"name {GenerateUniqueId()}")
//    .WithType("variable")
//    .WithAttribute(attribute1)
//    .WithAttribute(attribute2)
//    .WithImage(new ProductImage() { Id = 50413 })
//    .Build();

//var variation1 = new ProductVariationBuilder()
//    .WithRegularPrice("1500.00")
//    .WithAttribute(new ProductVariationAttribute { Name = "CCC", Option = "Red" })
//    .WithAttribute(new ProductVariationAttribute { Name = "ZZZ", Option = "Small" })
//    .WithImage(new MediaItemRequest() { Id = 50522 })
//    .Build();

//// Create more variations...

//var productVariationsRequest = new ProductVariationsRequest
//{
//    Create = new[] { variation1, /* more variations... */ }
//};