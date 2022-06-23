//using Google.Apis.Discovery;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.Swagger;
//using Swashbuckle.AspNetCore.SwaggerGen;
//using Swashbuckle.Swagger;

//using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class HeaderFilter : IOperationFilter
    {
        
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, System.Web.Http.Description.ApiDescription apiDescription)
        {
            if (operation.parameters == null)
                operation.parameters = new List<Parameter>();

            operation.parameters.Add(new Parameter
            {
                name = "MyHeaderField",
                @in = "header",
                type = "string",
                description = "My header field",
                required = true
            });
        }
    }
}
