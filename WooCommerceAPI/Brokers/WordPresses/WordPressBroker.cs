﻿using RESTFulSense.Clients;
using System.Net.Http.Headers;
using System.Text;
using WooCommerceAPI.Models.Configurations;

namespace WooCommerceAPI.Brokers.WordPresses
{
    internal partial class WordPressBroker : IWordPressBroker
    {
        private readonly WordPressConfigurations wordPressConfigurations;
        private readonly IRESTFulApiFactoryClient apiClient;
        private readonly HttpClient httpClient;

        public WordPressBroker(WordPressConfigurations wordPressConfigurations)
        {
            this.wordPressConfigurations = wordPressConfigurations;
            this.httpClient = SetupHttpClient();
            this.apiClient = SetupApiClient();
        }

        private async ValueTask<TResult> PostFormAsync<TRequest, TResult>(string relativeUrl, TRequest content)
            where TRequest : class
        {
            return await this.apiClient.PostFormAsync<TRequest, TResult>(
                relativeUrl,
                content);
        }

        private HttpClient SetupHttpClient()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri(uriString: this.wordPressConfigurations.ApiUrl),
            };
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    scheme: "Basic",
                    parameter: Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.wordPressConfigurations.UserName}:{this.wordPressConfigurations.AppPassword}")));

            return httpClient;
        }

        private IRESTFulApiFactoryClient SetupApiClient() =>
            new RESTFulApiFactoryClient(this.httpClient);
    }
}
