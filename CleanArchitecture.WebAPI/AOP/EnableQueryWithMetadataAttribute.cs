using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.AspNetCore.OData.Query;
using System.Text.Json.Serialization;

namespace CleanArchitecture.WebAPI.AOP;

public class EnableQueryWithMetadataAttribute : EnableQueryAttribute
{
    public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
    {
        base.OnActionExecuted(actionExecutedContext);

        if (actionExecutedContext.Result is ObjectResult obj && obj.Value is IQueryable qry)
        {
            obj.Value = new ODataResponse
            {
                Total = actionExecutedContext.HttpContext.Request.ODataFeature().TotalCount,
                Data = qry
            };
        }
    }
    public class ODataResponse
    {
        [JsonPropertyName("total")]
        public long? Total { get; set; }

        [JsonPropertyName("data")]
        public IQueryable Data { get; set; } = default!;
    }
}