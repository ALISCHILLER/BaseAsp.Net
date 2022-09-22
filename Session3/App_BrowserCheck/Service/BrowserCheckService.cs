using App_BrowserCheck.Middleware.Core;

namespace App_BrowserCheck.Service
{
    public class BrowserCheckService : IBrowserCheckService
    {
        public bool Validate(HttpContext context)
        {
          var result=context.Request.Headers["user-Agent"].Any(value => value.Contains("Trident"));

          return result;            
     }
    }
}