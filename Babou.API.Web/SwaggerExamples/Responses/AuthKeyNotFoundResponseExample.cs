﻿using Swashbuckle.AspNetCore.Filters;

namespace Babou.API.Web.SwaggerExamples.Responses
{
    public class AuthKeyNotFoundResponseExample : IExamplesProvider<string>
    {
        public string GetExamples()
        {
            return "AuthKey not found.";
        }
    }
}
