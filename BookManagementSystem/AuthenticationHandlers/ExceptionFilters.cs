using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace BookManagementSystem.AuthenticationHandlers
{
    public class ExceptionFilters : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        string message = string.Empty;
        
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var exceptionType = actionExecutedContext.GetType();
/*            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;
*/            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            if (exceptionType == typeof(NullReferenceException))
            {
                message = "Id can not be null.";
                actionExecutedContext.Response = new HttpResponseMessage( HttpStatusCode.BadRequest);
            }
            if (exceptionType == typeof(KeyNotFoundException))
            {
                message = "Key not found.";
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

    }
}
