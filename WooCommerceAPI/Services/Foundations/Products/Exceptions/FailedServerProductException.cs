﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System;
using Xeptions;

namespace Standard.AI.OpenAI.Models.Services.Foundations.Products.Exceptions
{
    public class FailedServerProductException : Xeption
    {
        public FailedServerProductException(Exception innerException)
            : base(
                message: "Failed Product server error occurred, contact support.",
                    innerException: innerException)
        { }

        public FailedServerProductException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}