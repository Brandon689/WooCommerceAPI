﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooCommerceAPI.Models.Services.Foundations.Products;
using WooCommerceAPI.Services.Foundations.Products.Exceptions;

namespace WooCommerceAPI.Services.Foundations.Products
{
    internal partial class ProductService
    {
        private delegate ValueTask<Product> ReturningProductFunction();

        private async ValueTask<Product> TryCatch(ReturningProductFunction returningProductFunction)
        {
            try
            {
                return await returningProductFunction();
            }
            catch (NullProductException nullProductException)
            {
                throw new ProductValidationException(nullProductException);
            }
            //catch (InvalidProductException invalidProductException)
            //{
            //    throw new ProductValidationException(invalidProductException);
            //}
            //catch (HttpResponseUrlNotFoundException httpResponseUrlNotFoundException)
            //{
            //    var invalidConfigurationProductException =
            //        new InvalidConfigurationProductException(httpResponseUrlNotFoundException);

            //    throw new ProductDependencyException(invalidConfigurationProductException);
            //}
            //catch (HttpResponseUnauthorizedException httpResponseUnauthorizedException)
            //{
            //    var unauthorizedProductException =
            //        new UnauthorizedProductException(httpResponseUnauthorizedException);

            //    throw new ProductDependencyException(unauthorizedProductException);
            //}
            //catch (HttpResponseForbiddenException httpResponseForbiddenException)
            //{
            //    var unauthorizedProductException =
            //        new UnauthorizedProductException(httpResponseForbiddenException);

            //    throw new ProductDependencyException(unauthorizedProductException);
            //}
            //catch (HttpResponseNotFoundException httpResponseNotFoundException)
            //{
            //    var notFoundProductException =
            //        new NotFoundProductException(httpResponseNotFoundException);

            //    throw new ProductDependencyValidationException(notFoundProductException);
            //}
            //catch (HttpResponseBadRequestException httpResponseBadRequestException)
            //{
            //    var invalidProductException =
            //        new InvalidProductException(httpResponseBadRequestException);

            //    throw new ProductDependencyValidationException(invalidProductException);
            //}
            //catch (HttpResponseTooManyRequestsException httpResponseTooManyRequestsException)
            //{
            //    var excessiveCallProductException =
            //        new ExcessiveCallProductException(httpResponseTooManyRequestsException);

            //    throw new ProductDependencyValidationException(excessiveCallProductException);
            //}
            //catch (HttpResponseException httpResponseException)
            //{
            //    var failedServerProductException =
            //        new FailedServerProductException(httpResponseException);

            //    throw new ProductDependencyException(failedServerProductException);
            //}
            //catch (Exception exception)
            //{
            //    var failedProductServiceException =
            //        new FailedProductServiceException(exception);

            //    throw new ProductServiceException(
            //        failedProductServiceException);
            //}
        }
    }

}
