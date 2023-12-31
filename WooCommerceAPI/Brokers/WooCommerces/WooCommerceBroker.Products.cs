﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooCommerceAPI.Models.Services.Foundations.ExternalProducts;

namespace WooCommerceAPI.Brokers.WooCommerces
{
    internal partial class WooCommerceBroker
    {
        public async ValueTask<ExternalProductResponse> PostProductRequestAsync(
            ExternalProductRequest externalProductRequest)
        {
            return await PostAsync<ExternalProductRequest, ExternalProductResponse>(
                relativeUrl: "/wp-json/wc/v3/products",
                content: externalProductRequest);
        }
    }
}
