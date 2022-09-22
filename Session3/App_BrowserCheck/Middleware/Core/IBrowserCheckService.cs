namespace App_BrowserCheck.Middleware.Core
{
    public interface IBrowserCheckService
    {
         bool Validate(HttpContext context);
    }
}