﻿using dotenv.net;
using WooCommerceAPI.Clients.WooCommerces;
using WooCommerceAPI.Models.Configurations;
using WooCommerceAPI.Models.Services.Foundations.Products;

DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { "../../../.env" }));

var openAIConfigurations = new WooCommerceConfigurations
{
    ApiKey = Environment.GetEnvironmentVariable("WC_CONSUMER_KEY"),
    ApiSecret = Environment.GetEnvironmentVariable("WC_CONSUMER_SECRET"),
    ApiUrl = Environment.GetEnvironmentVariable("WC_STORE_URL")
};

var openAIClient = new WooCommerceClient(openAIConfigurations);

ProductAttribute[] a = new ProductAttribute[3];


var inputProduct = new Product
{
    Request = new ProductRequest
    {
        Name = "name 8",
        Type = "simple",
        RegularPrice = "10",
        //Attributes = a
    }
};

Product result = await openAIClient.Products.SendProductAsync(inputProduct);
Console.WriteLine(result.Response.Name);