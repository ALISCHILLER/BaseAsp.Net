namespace App.Middleware.Core
{
    public interface IBrowserCheckService
    {
         bool Validate(HttpContext context);
    }
}